using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EF_Practice.Models;
using Prism.Mvvm;

namespace EF_Practice.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private string title = "Prism Application";

    public MainWindowViewModel()
    {
        Debug.WriteLine($"{"コンストラクタ"}(MainWindowViewModel : 15)");
        var context = new DatabaseContext();
        context.Database.EnsureCreated();
        context.Add(new Record());
        M(context.Records);
    }

    public string Title { get => title; set => SetProperty(ref title, value); }

    private void M(IEnumerable<Record> recs)
    {
        Debug.WriteLine($"{"execute"}(MainWindowViewModel : 25)");
        var rs = recs.Where(r => true);
        foreach (var r in rs)
        {
            Debug.WriteLine($"{r.Id}(MainWindowViewModel : 25)");
        }
    }
}