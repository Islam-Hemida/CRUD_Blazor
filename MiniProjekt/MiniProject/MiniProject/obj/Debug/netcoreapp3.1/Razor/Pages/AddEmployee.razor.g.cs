#pragma checksum "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88eb23ceddd8b9b8edc5374c4943d815d30d925"
// <auto-generated/>
#pragma warning disable 1591
namespace MiniProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using MiniProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MiniProjekt\MiniProject\MiniProject\_Imports.razor"
using MiniProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
using MiniProject.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2> Add Employee</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"Control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
                                                                objEmp.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Name = __value, objEmp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                <label for=\"Gender\" class=\"Control-label\"></label>\r\n                ");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
                                objEmp.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Gender = __value, objEmp.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", true);
            __builder.AddContent(30, "--Select Gender--");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "Male");
            __builder.AddContent(34, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "Female");
            __builder.AddContent(38, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label for=\"Country\" class=\"Control-label\">Country</label>\r\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "form", "Country");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
                                                                   objEmp.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Country = __value, objEmp.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.AddMarkupContent(56, "<label for=\"City\" class=\"Control-label\">City</label>\r\n                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "form", "City");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
                                                                objEmp.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.City = __value, objEmp.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "class>\r\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row");
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-md-4");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "class", "btn btn-primary");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
                                                                    CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, " \r\n            ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "class", "btn btn-primary");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\MiniProjekt\MiniProject\MiniProject\Pages\AddEmployee.razor"
       
    EmployeeInfo objEmp = new EmployeeInfo();

    protected void CreateEmployee()
    {
        objEmpService.Create(objEmp);
        NavigationManager.NavigateTo("Employee");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService objEmpService { get; set; }
    }
}
#pragma warning restore 1591
