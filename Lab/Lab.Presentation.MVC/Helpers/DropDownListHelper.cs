﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.ComponentModel;
using System.Linq.Expressions;
using Lab.Resources;

namespace Lab.Presentation.MVC.Helpers
{
    public static class DropDownListHelper
    {
        public static MvcHtmlString CustomEnumDropDownListFor<TModel, TEnum>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TEnum>> expression, string optionLabel, object htmlAttributes)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var values = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();

            var items = values.Select(p => new SelectListItem
            {
                Text = Resource.ResourceManager.GetString(p.ToString()),
                Value = p.ToString(),
                Selected = p.Equals(metadata.Model)
            });

            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            return htmlHelper.DropDownListFor(expression, items, optionLabel, attributes);
        }
    }
}