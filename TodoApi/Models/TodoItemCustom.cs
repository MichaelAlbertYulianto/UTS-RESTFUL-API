using Microsoft.CodeAnalysis.CSharp.Syntax;
using TodoApi.Models;

namespace TodoApi;

public class TodoItemCustom
{
    public int Count { set; get; }
    public List<TodoItem> DatatodoItems {set; get;}

    public TodoItemCustom(int count, List<TodoItem> datatodoitem)
    {
        Count = count;
        DatatodoItems =datatodoitem;
    }
}
