#pragma checksum "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499b82266ab341ac1140c13b7a6668d094fad55b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\_ViewImports.cshtml"
using Books;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\_ViewImports.cshtml"
using Books.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499b82266ab341ac1140c13b7a6668d094fad55b", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64118b9daec79e61479b03789289a469d2c9c5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Books.Data.ViewModels.NewBookVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Book details";

    var rattingSum = ViewBag.RattingSum;
    var rattingCount = ViewBag.RattingCount;

    decimal ratting = 0;
    if (rattingCount > 0)
    {
        ratting = rattingSum / rattingCount;
    }
    var totalRatting = decimal.Parse(ratting.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""card mb-12"">
            <div class=""row g-0"">
                <div class=""col-md-12"">
                    <div class=""card-header text-white bg-info"">
                        <p class=""card-text"">
                            <h5 class=""card-title"">
                                ");
#nullable restore
#line 25 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 914, "\"", 935, 1);
#nullable restore
#line 31 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
WriteAttributeValue("", 920, Model.ImageURL, 920, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 949, "\"", 966, 1);
#nullable restore
#line 31 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
WriteAttributeValue("", 955, Model.Name, 955, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\"><b>Tác giả: </b>");
#nullable restore
#line 35 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                        Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Thể loại: </b>");
#nullable restore
#line 36 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                         Write(Model.BookType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Ngày phát hành: </b>");
#nullable restore
#line 37 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                               Write(Model.ReleaseDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Số lượng: </b>");
#nullable restore
#line 38 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                         Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Mô tả: </b>");
#nullable restore
#line 39 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"card-footer\">\r\n                        <p class=\"card-text\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499b82266ab341ac1140c13b7a6668d094fad55b11294", async() => {
                WriteLiteral("\r\n                                Trở về\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499b82266ab341ac1140c13b7a6668d094fad55b12691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 49 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Count);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "499b82266ab341ac1140c13b7a6668d094fad55b14265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Count);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499b82266ab341ac1140c13b7a6668d094fad55b16041", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 51 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Count);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499b82266ab341ac1140c13b7a6668d094fad55b17719", async() => {
                WriteLiteral("\r\n                               <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2565, "\"", 2573, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                               <i class=\"bi bi-cart-plus\"></i> Thêm vào giỏ hàng (Price ");
#nullable restore
#line 57 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2279, "btn", 2279, 3, true);
            AddHtmlAttributeValue(" ", 2282, "btn-success", 2283, 12, true);
            AddHtmlAttributeValue(" ", 2294, "text-white", 2295, 11, true);
#nullable restore
#line 53 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
AddHtmlAttributeValue("  ", 2305, (DateTime.Now < Model.ReleaseDate) ? "disabled" : "", 2307, 55, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 61 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                 if (User.Identity.IsAuthenticated) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-12\">\r\n                        <div class=\"card-body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "499b82266ab341ac1140c13b7a6668d094fad55b21996", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"card-footer\">\r\n                            <p class=\"card-text\">\r\n                                <h3>Có ");
#nullable restore
#line 71 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                  Write(Model.ListOfComments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" đánh giá</h3>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"card-body\">\r\n");
#nullable restore
#line 77 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                             if (Model.ListOfComments != null && Model.ListOfComments.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                 foreach (var item in Model.ListOfComments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <hr />\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-md-12\">\r\n                                            <i>Khách hàng: <b>");
#nullable restore
#line 84 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                         Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>- Ngày: <b>");
#nullable restore
#line 84 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                                                     Write(item.RattingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></i>\r\n                                            <br />\r\n                                            <div class=\" float-right\">\r\n");
#nullable restore
#line 87 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                 for (var i = 1; i <= item.Star; i++)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"text-warning fas fa-star \"></span>\r\n");
#nullable restore
#line 90 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                 for (var i = (item.Star + 1); i <= 5; i++)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"text-warning far fa-star\"></span>\r\n");
#nullable restore
#line 94 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                        <div class=\"col-md-9\">\r\n                                            <b>");
#nullable restore
#line 98 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                          Write(Html.Raw(item.Comment.Replace("\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 101 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>No Comment</p>\r\n");
#nullable restore
#line 106 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 109 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#rateMe1\').mdbRate();\r\n        });\r\n\r\n        function SCRate() {\r\n            for (var i = 1; i <= ");
#nullable restore
#line 124 "D:\Duong\HKI2022-2023\LTW\complete-ecommerce-aspnet-mvc-application\eTickets\Views\Books\Details.cshtml"
                            Write(totalRatting);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"; i++) {
                $(""#sRate"" + i).attr('class', 'starGlowN');
            }
        }
        $(function () {
            SCRate();
        });

        $('.rattingStar').hover(function() {
            $('.rattingStar').addClass('far').removeClass('fas');

            $(this).addClass('fas').removeClass('far');
            $(this).prevAll('.rattingStar').addClass('fas').removeClass('far');
        });

        $('.rattingStar').click(function() {
            var starValue = $(this).attr('td-value');

            $('#Star').val(starValue);
        })
    </script>

    ");
            }
            );
            WriteLiteral("\r\n    <style>\r\n        .checked {\r\n            color: orange;\r\n        }\r\n    </style>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Books.Data.ViewModels.NewBookVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591