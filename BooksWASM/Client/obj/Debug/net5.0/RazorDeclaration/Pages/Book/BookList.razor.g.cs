// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BooksWASM.Client.Pages.Book
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using BooksWASM.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookList.razor"
using BooksWASM.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Books")]
    public partial class BookList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "c:\Users\snake\OneDrive - Universidad Católica Nordestana (UCNE)\Escritorio\BooksWASM\BooksWASM\Client\Pages\Book\BookList.razor"
       

    private int bookId;
    private string id;

    private Books[] books;
    private Books book;

    protected override async Task OnInitializedAsync()
    {
        books = await bookServices.GetBooks();
        book = null;
    }

    private async Task SearchBook()
    {
        try
        {
            if (string.IsNullOrEmpty(id))
            {
                book = null;
                books = await bookServices.GetBooks();
                return;
            }

            bookId = Convert.ToInt32(id);
            book = await bookServices.GetBook(bookId);
            
            if(bookId == book.Id)
            {
                Toast.ShowSuccess($"Found book with id {book.Id}");
            } 
            else
            {
                Toast.ShowError($"Not an existing book with id {bookId}");
            }
        } 
        catch (Exception e)
        {
            Toast.ShowError($"Error: {e.Message}");
        }
    }

    private void BookDetail(int id)
    {
        NavigationManager.NavigateTo($"/Books/{id}");
    }

    private void DeleteBook(int id)
    {
        NavigationManager.NavigateTo($"/Books/{id}/Delete");
    }

    private void AddBook()
    {
        NavigationManager.NavigateTo("/Books/Add");
    }

    private void UpdateBook(int id)
    {
        NavigationManager.NavigateTo($"/Books/{id}/Edit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBooksServices bookServices { get; set; }
    }
}
#pragma warning restore 1591
