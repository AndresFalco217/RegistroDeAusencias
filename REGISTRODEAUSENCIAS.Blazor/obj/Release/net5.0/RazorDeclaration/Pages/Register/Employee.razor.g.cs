// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace REGISTRODEAUSENCIAS.Blazor.Pages.Register
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using REGISTRODEAUSENCIAS.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using REGISTRODEAUSENCIAS.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using REGISTRODEAUSENCIAS.Blazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\Pages\Register\Employee.razor"
       
    public REGISTRODEAUSENCIAS.Blazor.Data.Models.EmployeeModel Model { get; set; } = new Data.Models.EmployeeModel();
    public List<REGISTRODEAUSENCIAS.Blazor.Data.Models.EmployeeModel> ListEmployee { get; set; } = new List<Data.Models.EmployeeModel>();


    protected override void OnInitialized()
    {
        loademployees();
    }

    protected void loademployees()
    {
        var result = employeeServices.ListEmployees();
        ListEmployee = result;
    }

    protected void AddEmployee()
    {

        var result = employeeServices.Register(Model);
        if (result.IsSuccess)
        {
            Model.Id = result.Code;
            ListEmployee.Add(Model);

            Model = new Data.Models.EmployeeModel();
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }
    }

    protected void UpdateEmployee(REGISTRODEAUSENCIAS.Blazor.Data.Models.EmployeeModel employee)
    {

        var result = employeeServices.Update(employee);
        if (result.IsSuccess)
        {
            Model = new Data.Models.EmployeeModel();
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }
    }

    protected void DeleteEmployee(int idEmployee)
    {
        var result = employeeServices.Delete(idEmployee);
        if (result.IsSuccess)
        {
            loademployees();
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeServices employeeServices { get; set; }
    }
}
#pragma warning restore 1591
