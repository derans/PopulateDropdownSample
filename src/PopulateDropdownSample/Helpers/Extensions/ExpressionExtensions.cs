using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PopulateDropdownSample.Helpers.Extensions
{
    public static class ExpressionExtensions
    {
        public static PropertyInfo GetProperty<T, TProperty>(this Expression<Func<T, TProperty>> expression)
        {
            return (PropertyInfo)GetExpressionBody(expression).Member;
        }

        private static MemberExpression GetExpressionBody<T, TProperty>(Expression<Func<T, TProperty>> expression)
        {
            var body = expression.Body;

            if (expression.Body.NodeType == ExpressionType.Convert)
                body = ((UnaryExpression)expression.Body).Operand;

            return (MemberExpression)body;
        }
    }
}