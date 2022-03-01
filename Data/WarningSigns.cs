using System.ComponentModel;

namespace MasaBlazorStandardTablePage.Data;

public enum WarningSigns
{
    [Description("高温黄色预警 35℃")]
    Yellow = 1,
    [Description("高温橙色预警 37℃")]
    Orange,
    [Description("高温红色预警 39℃")]
    Red
}