#pragma checksum "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d981d3bb2376eed6445a00eb4524087afb85ef"
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
#line 2 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
using MiniProject.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployee/{CurrentID}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2> Update Employee</h2>\r\n<hr>\r\n\r\n");
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
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "for", "name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                                               objEmp.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.EmployeeId = __value, objEmp.EmployeeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<label for=\"Name\" class=\"Control-label\">Name</label>\r\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "form", "Name");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                                                objEmp.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Name = __value, objEmp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                <label for=\"Gender\" class=\"Control-label\"></label>\r\n                ");
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                objEmp.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Gender = __value, objEmp.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", true);
            __builder.AddContent(40, "--Select Gender--");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "Male");
            __builder.AddContent(44, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "Female");
            __builder.AddContent(48, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddMarkupContent(55, "<label for=\"Country\" class=\"Control-label\">Country</label>\r\n                ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "form", "Country");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                                                   objEmp.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Country = __value, objEmp.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, "<label for=\"City\" class=\"Control-label\">City</label>\r\n                ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "form", "City");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                                                objEmp.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.City = __value, objEmp.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-md-4");
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "button");
            __builder.AddAttribute(84, "class", "btn btn-primary");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                                                    UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "class", "btn btn-primary");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\MiniProjekt\MiniProject\MiniProject\Pages\EditEmployee.razor"
       
    [Parameter]
    public string CurrentID { get; set; }

    EmployeeInfo objEmp = new EmployeeInfo();

    protected override async Task OnInitializedAsync()
    {
        objEmp = await Task.Run(() => objEmpService.GetEmployeeById(Convert.ToInt32(CurrentID)));
    }

    protected void UpdateEmployee()
    {
        objEmpService.UpdateEmployee(objEmp);
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