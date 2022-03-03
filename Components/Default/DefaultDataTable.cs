using BlazorComponent;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using OneOf;

namespace MasaBlazorStandardTablePage;

public class DefaultDataTable<T> : MDataTable<T>
{
    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        FooterProps = new Dictionary<string, object>()
        {
            {
                "ItemsPerPageOptions", new List<OneOf<int, DataItemsPerPageOption>>() { 5, 10, 15 }
            }
        };
    }
}