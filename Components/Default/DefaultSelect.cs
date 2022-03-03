using Masa.Blazor;
using Microsoft.AspNetCore.Components;

namespace MasaBlazorStandardTablePage;

public class DefaultSelect<TItem, TItemValue, TValue> : MSelect<TItem, TItemValue, TValue>
{
    public override async Task SetParametersAsync(ParameterView parameters)
    {
        Clearable = true;
        Dense = true;
        HideDetails = "auto";
        Outlined = true;
        
        await base.SetParametersAsync(parameters);
    }
}