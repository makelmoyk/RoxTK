#pragma checksum "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c3c3cbfbf37237d302ce85143d82458cf885de"
// <auto-generated/>
#pragma warning disable 1591
namespace RoxTK.WebClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using RoxTK.WebClient;

#line default
#line hidden
#line 9 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using RoxTK.WebClient.Shared;

#line default
#line hidden
#line 10 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using Moyk.Components;

#line default
#line hidden
#line 11 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\_Imports.razor"
using RoxTK.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
 if (Employee == null)
{

#line default
#line hidden
            __builder.AddMarkupContent(0, "    <div class=\"lds-dual-ring\"></div>\r\n");
#line 7 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-7");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h1");
            __builder.AddContent(15, 
#line 14 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#line 14 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body text-center");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "card-img-top");
            __builder.AddAttribute(25, "src", 
#line 17 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                                                    Employee.ImagePath

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                    ");
            __builder.OpenElement(27, "h4");
            __builder.AddContent(28, "Employee ID: ");
            __builder.AddContent(29, 
#line 19 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                                      Employee.EmployeeId

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "h4");
            __builder.AddContent(32, "Email: ");
            __builder.AddContent(33, 
#line 20 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                                Employee.Email

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "h4");
            __builder.AddContent(36, "Department: ");
            __builder.AddContent(37, 
#line 21 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                                      Employee.Department == null ? "N/A" : Employee.Department.DepartmentName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card-footer text-center");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "href", "editemployee/" + (
#line 25 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
                                           Employee.EmployeeId

#line default
#line hidden
            ));
            __builder.AddAttribute(46, "class", "btn btn-info");
            __builder.AddContent(47, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddMarkupContent(49, "<a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#line 31 "C:\Users\Michael Angelo Agana\Desktop\MY FILES\RoxTK\Rox.WebClient\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
