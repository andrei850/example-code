
$(document).ready(function () {

    $("#treelist").kendoTreeList({
        dataSource: new kendo.data.TreeListDataSource({
            transport: {
                read: {
                    url: "/Home/CreateList",
                    dataType: "json"
                }
            }
        }),
        columns: [
            { field: "CountID" },
            { field: "Reason" }
        ]
    });
    

    // Get a reference to the kendo.ui.TreeList instance.
    var treelist = $("#treelist").data("kendoTreeList");

});