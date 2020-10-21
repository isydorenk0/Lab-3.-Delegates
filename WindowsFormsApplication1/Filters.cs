using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WindowsFormsApplication1
{
    public class Filters 
    {
        public IEnumerable<Message> GetFilter(FiltersFlds filterFlds, List<Message> messages)
        {
            var param = Expression.Parameter(typeof(Message), "name");
            Expression filterCond = FilterByDate(param, filterFlds.minDate, filterFlds.maxDate);
            if (filterFlds.selectedNumber != null)
            {
                Expression filterNumber = FilterByNumber(param, filterFlds.selectedNumber);
                filterCond = joinExpressions(filterCond, filterNumber, filterFlds.filterLgc);
            }

            if (filterFlds.filterMsg != null)
            {
                Expression filterText = FilterByMsg(param, filterFlds.filterMsg);
                filterCond = joinExpressions(filterCond, filterText, filterFlds.filterLgc);
            }

            var results = Expression.Lambda<Func<Message, bool>>(
                          filterCond,
                          new ParameterExpression[] { param });

            var queMessages = messages.AsQueryable();
            var query = queMessages.Where(results);
            return query;
        }

        public Expression joinExpressions(Expression genFilter, Expression addFilter, string logicFilter)
        {
            if (logicFilter == "AND")
            {
                return Expression.And(genFilter, addFilter);
            }
            else
            {
                return Expression.Or(genFilter, addFilter);
            }
        }

        public Expression FilterByMsg(ParameterExpression param, string filterMsg)
        {
            var filterText = Expression.Call(Expression.Property(param, "Text"),
                            typeof(string).GetMethod("Contains", new[] { typeof(string) }),
                            Expression.Constant(filterMsg, typeof(string)));
            return filterText;
        }

        public Expression FilterByDate(ParameterExpression param, DateTime minDate, DateTime maxDate)
        {
            Expression filterMinDate = Expression.GreaterThanOrEqual(
                                       Expression.Property(param, "ReceivingTime"),
                                       Expression.Constant(minDate, typeof(DateTime)));
            Expression filterMaxDate = Expression.LessThanOrEqual(
                                       Expression.Property(param, "ReceivingTime"),
                                       Expression.Constant(maxDate, typeof(DateTime)));
            Expression filterDate = Expression.And(
                                    filterMinDate,
                                    filterMaxDate);
            return filterDate;
        }        

        public Expression FilterByNumber(ParameterExpression param, string selectedNumber)
        {
            var number = Expression.Equal(
                         Expression.Property(param, "Number"),
                         Expression.Constant(selectedNumber)
                         );
            return number;
        }
    }
}
