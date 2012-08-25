using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using PopulateDropdownSample.Helpers.Attributes;

namespace PopulateDropdownSample.Helpers.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> expression) where TModel : class
        {
            var property = expression.GetProperty();
            IEnumerable<SelectListItem> selectList;

            var selectListProviderAttribute = property.GetAttribute<SelectListProviderAttribute>();

            if (selectListProviderAttribute != null)
            {
                var provider = selectListProviderAttribute.Provider;
                selectList = provider.Provide();
            }
            else
            {
                throw new ArgumentException(string.Format("SelectListProvider not specified for property \"{0}\"", property.Name));
            }

            return html.DropDownListFor(expression, selectList);
        }
    }
}