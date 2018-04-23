# How to change focused row background


<p>This sample shows how to change the background of a data row when it is focused or selected.</p><p>The main idea is to define a custom <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGridTableView_DataRowTemplatetopic"><u>DataRowTemplate</u></a> and place an additional border within this template. The data context of DataRowTemplate is a <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGridRowDataMembersTopicAll"><u>RowData</u></a> class object. Therefore, the border's Background can be bound to the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGridRowData_SelectionStatetopic"><u>SelectionState</u></a> property via a converter.</p><p>See also: '<a href="https://www.devexpress.com/Support/Center/p/E3320">E3320: How to display different colors for even/odd rows</a>', '<a href="https://www.devexpress.com/Support/Center/p/E3889">E3889: How to change focused row foreground</a>'</p>

<br/>


