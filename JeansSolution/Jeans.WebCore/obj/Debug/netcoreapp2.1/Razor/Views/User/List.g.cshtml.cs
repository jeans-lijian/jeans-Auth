#pragma checksum "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\User\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1676c63c62da356cdcbb54e7a4d8b96f91fad32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_List), @"mvc.1.0.view", @"/Views/User/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/List.cshtml", typeof(AspNetCore.Views_User_List))]
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
#line 1 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\_ViewImports.cshtml"
using Jeans.WebCore;

#line default
#line hidden
#line 2 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\_ViewImports.cshtml"
using Jeans.WebCore.Models;

#line default
#line hidden
#line 3 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\_ViewImports.cshtml"
using Jeans.WebCore.Models.Account;

#line default
#line hidden
#line 4 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\_ViewImports.cshtml"
using Jeans.WebCore.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1676c63c62da356cdcbb54e7a4d8b96f91fad32", @"/Views/User/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce88c3a1f6a17bb7a91d1f307206e81e87afa24", @"/Views/_ViewImports.cshtml")]
    public class Views_User_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\User\List.cshtml"
  
    ViewData["Title"] = "用户列表";

#line default
#line hidden
            BeginContext(40, 71, true);
            WriteLiteral("\r\n<section class=\"content-header clearfix\">\r\n    <h1 class=\"pull-left\">");
            EndContext();
            BeginContext(112, 13, false);
#line 6 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\User\List.cshtml"
                     Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(125, 807, true);
            WriteLiteral(@"</h1>
    <div class=""pull-right"">
        <input type=""button"" class=""btn btn-primary"" value=""新增"" />
    </div>
</section>
<section class=""content container-fluid"">
    <div class=""box box-primary"">
        <div class=""box-header with-border"">
            <div class=""row"">
                <div class=""col-sm-7"">
                    <input type=""text"" id=""txtNameEmpNo"" class=""form-control"" placeholder=""姓名或工号"" />
                </div>
                <div class=""col-sm-5"">
                    <input type=""button"" class=""btn btn-primary"" id=""btn_search"" value=""搜索"" />
                </div>
            </div>
        </div>

        <div class=""box-body no-padding"">
            <div class=""row"">
                <div class=""col-sm-12"" style=""padding-top:5px"">
                    ");
            EndContext();
            BeginContext(932, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879a3421b84440fea4f268b29ee54d2c", async() => {
                BeginContext(998, 3, true);
                WriteLiteral("Add");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1005, 640, true);
            WriteLiteral(@"
                    <a class=""btn btn-danger"" href="""">Delete</a>
                </div>
            </div>

            <table id=""tb-user"" class=""table table-striped table-bordered"" style=""width:100%;"">
                <thead>
                    <tr>
                        <th></th>
                        <th>姓名</th>
                        <th>性别</th>
                        <th>部门</th>
                        <th>处室</th>
                        <th>工作岗位</th>
                        <th>是否使用</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1662, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1669, 50, false);
#line 50 "E:\My_Source_Code\NetCore_ShopOrder\JeansSolution\Jeans.WebCore\Views\User\List.cshtml"
Write(await Html.PartialAsync("_TableCssScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1719, 2033, true);
                WriteLiteral(@"

    <script>
        var user_table;
        $(function () {
            user_table = $('#tb-user').DataTable({
                processing: true,
                serverSide: true,
                ordering: false,
                searching: false,
                ajax: {
                    url: ""/User/List"",
                    type: ""POST"",
                    data: function (d) {
                        d.nameEmpNo = $('#txtNameEmpNo').val();
                    }
                },
                columns: [
                    {
                        data: ""id"",
                        render: function (data, type, row) {
                            var op = '<a href=""/User/Detail/' + data + '"">详情</a>&nbsp;&nbsp;';
                            op += '<a href = ""/User/Delete/' + data + '"" > 删除</a>&nbsp;&nbsp;';
                            op += '<a href = ""/User/Edit/' + data + '"" >编辑</a>'
                            return op;
                        }
                    },
");
                WriteLiteral(@"                    {
                        data: ""name"",
                        render: function (data, type, row) {
                            return data + '(' + row.empNo + ')';
                        }
                    },
                    {
                        data: ""sex"",
                        render: function (data, type, row) {
                            return data == 'M' ? '男' : '女';
                        }
                    },
                    { data: ""department"" },
                    { data: ""room"" },
                    { data: ""job"" },
                    {
                        data: 'isUsed',
                        render: function (data, type, row) {
                            return data == 1 ? '是' : '否';
                        }
                    }
                ]
            });

            $('#btn_search').click(function () {
                user_table.ajax.reload();
            });
        });
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591