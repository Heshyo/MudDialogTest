using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace MyApplication.Components;

partial class LoadingDialog : ComponentBase
{
	[Parameter]
	public DefaultFocus DefaultFocus { get; set; } = DefaultFocus.Element;

	[CascadingParameter]
	public MudDialogInstance SelfInstance { get; set; } = default!;

	[Parameter]
	public bool ShowCancel { get; set; } = true;

	[Parameter]
	public string Text { get; set; } = default!;

	void Cancel()
	{
		SelfInstance.Close(DialogResult.Ok(false));
	}
}