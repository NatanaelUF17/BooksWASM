#pragma checksum "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b137c88fa18dd0f09526898a167d7936195c02"
// <auto-generated/>
#pragma warning disable 1591
namespace BooksWASM.Client.Pages.Book
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
using BooksWASM.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Books/{Id:int}/Delete")]
    public partial class BookDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Book Delete</h3>");
#nullable restore
#line 7 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
 if (Id > 0 && isDeleted)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Book with id: ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
                      Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " was deleted successfully");
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
}
else if (Id == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>There\'s no existing book with id 0 </p>");
#nullable restore
#line 14 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Book with id: ");
            __builder.AddContent(8, 
#nullable restore
#line 17 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
                      Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " was deleted successfully");
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookDelete.razor"
       
    [Parameter]
    public int Id { get; set; }

    private bool isDeleted;

    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            await booksServices.DeleteBook(Id);
            isDeleted = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksServices booksServices { get; set; }
    }
}
#pragma warning restore 1591