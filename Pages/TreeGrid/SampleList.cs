﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-functionalities",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default rendering of the Tree Grid with minimum configuration.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Tree Grid is used to represent the hierarchical data in a tabular format, combining the visual representation of Grid and TreeView controls.
                        It represents the data from datasource such as an array of JSON objects, OData web services, or DataManager binding data fields to columns or self-referential datasource.
                    </p>
                    <p>
                        In this demo, the Tree Grid is populated with its minimum default settings.
                    </p>"
                }
            },
             //new Sample
             //{
             //    Name = "Grid Lines",
             //    Category = "Tree Grid",
             //    Directory = "TreeGrid/TreeGrid",
             //    Url = "tree-grid/grid-lines",
             //    Type = SampleType.None,
             //    TitleTag = "TreeGrid . Grid Lines . Syncfusion Blazor Components",
             //    MetaDescription = "This demo for Syncfusion Blazor TreeGrid component demonstrates the visibility of the TreeGrid lines that separate the rows and columns.",
             //    SourceFiles = new List<SourceCollection>()
             //    {
             //        new SourceCollection
             //        {
             //            Id="GridLines",
             //            FileName="GridLines.razor"
             //        },
             //        new SourceCollection
             //        {
             //            Id="LinesData",
             //            FileName="SelfData.cs"
             //        }
             //    },
             //    ActionDescription = new string[] {
             //        @"<p>
             //            This sample demonstrates visibility of the treegrid lines that separates the rows and columns.
             //        </p>"
             //    },
             //    Description = new string[] {
             //        @"<p>
             //            The <code>GridLines</code> property is used to control the line visibility that separates the rows and columns. 
             //            TreeGrid allows us to display the following grid lines,
             //        </p>
             //        <ul>
             //        <li><code>GridLine.Default</code> - Shows the Horizontal line.</li>
             //        <li><code>GridLine.None</code> - Shows no line.</li>
             //        <li><code>GridLine.Both</code> - Shows both Horizontal and Vertical lines.</li>
             //        <li><code>GridLine.Horizontal</code> - Shows the Horizontal line.</li>
             //        <li><code>GridLine.Vertical</code> - Shows the Vertical line.</li>
             //        </ul>
             //        <p>
             //            In this demo, we set the vertical GridLine mode for the treegrid component.
             //        </p"
             //    }
             //},
            new Sample
            {
                Name = "Clipboard",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/clipboard",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="Clipboard.razor"
                    },
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates copy to clipboard functionality of the Tree Grid component. Select rows and click Copy
                        button from toolbar to copy content. To copy with header click Copy with header button from toolbar.
                    </p>"
                },
               Description = new string[]{
                    @"<p>Selected row or cell data in the Tree Grid can be copied into the clipboard using the Keyboard shortcuts and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~Copy.html'>Copy</a></code> method.</p>
                    <p>In this demo, selected rows data can be copied into the clipboard using the below Keyboard shortcuts or toolbar interactions.</p>
                    <ul>
                        <li><code>Ctrl + C</code> - Selected rows or cells data without header.</li>
                        <li><code>Ctrl + Shift + H</code> - Selected rows or cells data with header.</li>
                    </ul>"
                }
            },

            new Sample
            {
                Name = "Context Menu",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/context-menu",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName="ContextMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="ContextData",
                        FileName="TreeData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the usage of context menu in Tree Grid component. Right click anywhere on the Tree Grid to view context menu.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Tree Grid has options to show the context menu when right clicking on it. To configure the items in context menu, you should define either default or custom item in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ContextMenuItems.html'>ContextMenuItems</a></code> property. Each item will be shown based on its target. The default context menu items are,</p>
                    <ul>
                        <li><code>Edit</code> - Edit the current record.</li>
                        <li><code>Delete</code> - Delete the current record.</li>
                        <li><code>Save</code> - Save the edited record.</li>
                        <li><code>Cancel</code> - Cancel the edited state.</li>
                        <li><code>Copy</code> - Copy the selected records.</li>
                        <li><code>PdfExport</code> - Export the grid as Pdf format.</li>
                        <li><code>ExcelExport</code> - Export the grid as Excel format.</li>
                        <li><code>CsvExport</code> - Export the grid as CSV format.</li>
                        <li><code>SortAscending</code> - Sort the current column in ascending order.</li>
                        <li><code>SortDescending</code> - Sort the current column in descending order.</li>
                        <li><code>FirstPage</code> - Go to the first page.</li>
                        <li><code>PrevPage</code> - Go to the previous page.</li>
                        <li><code>LastPage</code> - Go to the last page.</li>
                        <li><code>NextPage</code> - Go to the next page.</li>
                    </ul>
                    <p>While using the Tree Grid in a touch environment, touch and hold the Tree Grid row cell to show the context menu.</p>
                    <p>In this demo, Context Menu feature is enabled by defining the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.TreeGrid.TreeGridModel%601~ContextMenuItems.html'>ContextMenuItems</a></code> property with the default items.</p>"
                }

            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the way of binding remote services to Tree Grid component. Here, the DataManager is used to bind the remote data with Tree Grid.
                    </p>"
                },
                Description = new string[] {
                    @"<p>Tree Grid can be bound to remote services by assigning the <code>DataSource</code> property with the instance of
                            DataManager.</p>

                    <p>The EjsDataManager, which will act as an interface between the service endpoint and the Tree Grid, will require the below minimal information to interact with service endpoint properly.
                    </p>
                    <ul>
                        <li><code>EjsDataManager->Url</code> - Defines the service endpoint to fetch data</li>
                        <li><code>EjsDataManager->Adaptor</code> - Defines the adaptor option. By default, <code>ODataAdaptor</code> is used
                            for remote binding.</li>
                    </ul>
                    <p>Adaptor is responsible for processing response and request from/to the service endpoint.
                        <strong>@syncfusion/ej2-data</strong> package provides some predefined adaptors which are designed to interact with
                        particular service endpoints. They are,</p>
                    <ul>
                        <li><code>UrlAdaptor</code> - Use this to interact any remote services. This is the base adaptor for all remote based
                            adaptors.</li>
                        <li><code>ODataAdaptor</code> - Use this to interact with OData endpoints.</li>
                        <li><code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.</li>
                        <li><code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.</li>
                        <li><code>WebMethodAdaptor</code> - Use this to interact with web methods.</li>
                    </ul>
                    <p>
                        More information on the data binding can be found in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/data-binding/?no-cache=1' >Data Binding</a></code>documentation section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/conditional-formatting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formatting",
                        FileName="ConditionalFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="formatdata",
                        FileName="Selfdata.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This samples demonstrates the way of customizing the cells by highlighting the cells of Duration column based on certain condition using <code>QueryCellInfo</code> event.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The appearance of cells can be customized by using the <code>QueryCellInfo</code> event. The QueryCellInfo event triggers for every cell. In that event handler, you can get <code>QueryCellInfoEventArgs</code> that contains the details of the cell.
                </p>
                    <p>More information about conditional formatting can be found in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/cell/#customize-cell-styles'> documentation</a></code>section.</p>"
                }
            },
            new Sample
            {
                Name = "Aggregates",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/aggregate",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Aggregate",
                        FileName="Aggregate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Aggregatedata",
                        FileName="ShipmentData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates aggregate functionality of the Tree Grid.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid supports aggregates which will be displayed at the footer.
                The aggregate configurations can be provided by the <code>
                    TreegridAggregates</code> property.</p>
                <p>The built-in aggregates are,</p>
                <ul>
                    <li><code>Sum</code></li>     
                    <li><code>Average</code></li>     
                    <li><code>Min</code></li>     
                    <li><code>Max</code></li>     
                    <li><code>Count</code></li>     
                    <li><code>TrueCount</code></li>     
                    <li><code>FalseCount</code></li>     
                </ul>    
                <p>
                    In this demo, the <code>FooterTemplate</code> property is used to display the Sum value for Duration column
                    TrueCount value for the Approved column.    
                </p>"
                }
            },
             //new Sample
             //{
             //    Name = "Column Formatting",
             //    Category = "Columns",
             //    Directory = "TreeGrid/TreeGrid",
             //    Url = "tree-grid/column-formatting",
             //    Type = SampleType.None,
             //    TitleTag = "TreeGrid . Column Formatting . Syncfusion Blazor Components",
             //    MetaDescription = "This demo for Syncfusion Blazor TreeGrid component explains how to display the content of TreeGrid columns based on the specified format in TreeGrid component.",
             //    SourceFiles = new List<SourceCollection>()
             //    {
             //        new SourceCollection
             //        {
             //            Id="Formatting",
             //            FileName="ColumnFormatting.razor"
             //        },
             //        new SourceCollection
             //        {
             //            Id="FormatData",
             //            FileName="FormatData.cs"
             //        }
             //    },
             //    ActionDescription = new string[] {
             //        @"<p>
             //            This sample demonstrates the way of displaying the content of TreeGrid columns based on the specified format.
             //        </p>"
             //    },
             //    Description = new string[] {
             //        @"<p>Format is the process of customizing the particular column data/values based on specific culture. The TreeGrid uses Internationalization library to format number and date values. 
             //            The format can be specified by using <code>
             //            Format</code> property of columns.</p>
             //            <p>
             //            In this demo, select the column and format from the property panel to format the corresponding column values.
             //            </p>"
             //    }
             //},
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnData",
                        FileName="TemplateData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the usage of template columns in Tree Grid. In this sample, we have shown images in Tree Grid columns
                    </p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid provides a way to use a custom layout for each cell using column template feature. The TreeGridcolumn <code>Template</code> sub component is used to insert the column template for the columns.
                        </p>
                        <p>In this demo, using column template, we have presented Employee Image column with Employee Photo.</p>"
                }
            },
            new Sample
            {
                Name = "Auto Wrap Column Cells",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/auto-wrap",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoWrap",
                        FileName="AutoWrap.razor"
                    },
                    new SourceCollection
                    {
                        Id="WrapData",
                        FileName="WrapData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid component with the auto wrap column cell feature. 
                    In this sample, you can see that Task Name column cell content exceeded the available width hence it has been wrapped into multiple lines.
                    </p>"
                },
                Description = new string[] {
                    @"<p>Auto wrap cell content can be enabled using <code>AllowTextWrap</code> property of the Tree Grid. Setting this property will wrap cell text on multiple lines. 
                        This feature is useful to view the cell content when it exceeds the cell width.</p>
                    <p>Setting this property will wrap the text in both content cell and header cell.</p>
                    <p>In this demo, the <code>AllowTextWrap</code> property is enabled, and you can also see that the Task Name column whose content exceeded the cell width is wrapped into multiple lines.
                    </p>
                    <p>
                        More information about Auto wrap cells can be found <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/cell/#auto-wrap'>Auto wrap</a></code> in this documentation section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/show-or-hide",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ShowHide",
                        FileName="ShowOrHide.razor"
                    },
                    new SourceCollection
                    {
                        Id="ShowOrHideData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates dynamic show/hide columns feature of Tree Grid.
                Select column name from the properties panel and click hide/show to toggle visibility.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid column can be showed/hidden dynamically using <code>ShowColumns
                    </code> and <code>HideColumns</code> method of the Tree Grid.</p>
                <p>In this demo, the columns can be showed and hidden by selecting the column name in the dropdown
                    and click the Show or Hide buttons to toggle visibility. And the column`s visibility is toggled based on the
                    <code>TreeGridColumn->HeaderText</code> value.</p>
                <br/>
                <p>The <code>TreeGridColumn->Visible</code> property specifies the visibility of a column.
                To hide a column at the initial rendering, set the <code>Visible</code> property of TreeGridColumn component to false.</p>"
                }
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/header-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Headertemplate",
                        FileName="Headerstemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="headertemplateData",
                        FileName="TemplateData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the usage of Header Templates in Tree Grid. In this sample, we have shown custom icons in the column headers.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid provides a way to define a custom element in header element. By inducing <code>HeaderTemplate</code> sub component in the columns, which will be used as the template for the header cell.
                        </p>
                        <p>In this demo, we have render customized template for all column headers.</p>"
                }
            },
             //new Sample
             //{
             //    Name = "Cell Alignment",
             //    Category = "Columns",
             //    Directory = "TreeGrid/TreeGrid",
             //    Url = "tree-grid/cell-alignment",
             //    Type = SampleType.None,
             //    TitleTag = "TreeGrid . Cell Alignment . Syncfusion Blazor Components",
             //    MetaDescription = "This demo for Syncfusion Blazor TreeGrid component shows how to align the content inside the cells of TreeGrid columns and headers.",
             //    SourceFiles = new List<SourceCollection>()
             //    {
             //        new SourceCollection
             //        {
             //            Id="CellAlignment",
             //            FileName="CellAlignment.razor"
             //        },
             //        new SourceCollection
             //        {
             //            Id="CellData",
             //            FileName="SelfData.cs"
             //        }
             //    },
             //    ActionDescription = new string[] {
             //        @"<p>
             //            This sample demonstrates the text alignment functionalities of the treegrid columns.
             //        </p>"
             //    },
             //    Description = new string[] {
             //        @"<p>
             //            Align both content and header text of particular column using the <code>TextAlign
             //            </code> property of columns. There are four possible ways to align content and header text of column, they are.
             //        <br>
             //    </p>
             //    <ul>
             //        <li><code>Right</code></li>
             //        <li><code>Left</code></li>
             //        <li><code>Center</code></li>
             //        <li><code>Justify</code></li>
             //    </ul>
             //    <p>
             //        In this sample, we have initially set the <code>TextAlign</code> property as Right for Duration, Start Date and End Date columns.        
             //    </p>"
             //    }
             //},
             //new Sample
             //{
             //    Name = "Stacked Header",
             //    Category = "Columns",
             //    Directory = "TreeGrid/TreeGrid",
             //    Url = "tree-grid/stacked-header",
             //    Type = SampleType.None,
             //    TitleTag = "TreeGrid . Stacked Header . Syncfusion Blazor Components",
             //    MetaDescription = "This demo for Syncfusion Blazor TreeGrid component explains explains how to provide a common header for the group of columns in TreeGrid component.",
             //    SourceFiles = new List<SourceCollection>()
             //    {
             //        new SourceCollection
             //        {
             //            Id="StackedHeader",
             //            FileName="StackedHeader.razor"
             //        },
             //        new SourceCollection
             //        {
             //            Id="StackedData",
             //            FileName="ShipmentData.cs"
             //        }
             //    },
             //    ActionDescription = new string[] {
             //        @"<p>
             //            This sample demonstrates the TreeGrid component with the stacked header feature. In this sample, we have shown multiple levels of column header.
             //        </p>"
             //    },
             //    Description = new string[] {
             //        @"<p>The TreeGrid columns can be stacked/grouped in order to show multiple levels of column header.
             //        It can be done by setting the <code>TreeGridColumns</code> property.
             //    </p>
             //    <p>
             //        In this demo, the columns <strong>Order ID, Order Name, Order Date</strong> are grouped under Order Details, the columns <strong>Shipment Category, Shipped Date, Units</strong> are grouped under Shipment Details and <strong>Price per Unit, Total Price</strong> are grouped under Price details.
             //    </p>"

             //    }
             //},
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-menu",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="MenuData",
                        FileName="SelfData.cs"
                    }
                },
                Description = new string[] {
                    @"
                <p>
                    Tree Grid has an option to show column menu while click on multiple icon of each column. The column menu has an integrated option to interact the features like sorting, filtering, column chooser and and autoFit.  
                    This features can be enabled by defining the <code>ShowColumnMenu
                    </code> as true. The default items are
                    <br>
                </p>
                <ul>
                        <li><code>SortAscending</code> - Sort the current column in ascending order.</li>
                        <li><code>SortDescending</code> - Sort the current column in descending order.</li>
                        <li><code>AutoFit</code> - Auto fit current column.</li>
                        <li><code>AutoFitAll</code> - Auto fit all columns.</li>
                        <li><code>ColumnChooser</code> - Choose the column visibility.</li>
                        <li><code>Filter</code> - Filter option is shown to filter the current column.
                </ul>
                
                <p>
                    In this demo, Column Menu feature has enabled by defining <code>ShowColumnMenu
                    </code> as true with sorting, filtering and column chooser options.
                </p>"
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default functionalities of the Column Menu. Click on multiple icon of each column to open the column menu.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/resizing",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resizing",
                        FileName="Resizing.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResizeData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid column resizing feature. Click and drag at the right corner of each column header to resize the column.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Tree Grid columns can be resized by clicking and dragging at the right edge of columns header. Set <code>AllowResizing
                    </code> property as true, to enable column resizing behavior in Tree Grid. You can also prevent the resize of the particular column by setting
                    <code>TreeGridColumn->AllowResizing</code> as false in columns definition.
                    </p>
                    <p>
                        In this demo, the Tree Grid is populated with its minimum default settings.
                    </p>"

                }
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/reorder",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Reorder",
                        FileName="Reorder.razor"
                    },
                    new SourceCollection
                    {
                        Id="ReorderData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates reordering feature of the Tree Grid columns.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Reordering can be enabled by setting <code>AllowReordering</code> property as true.
                Reordering can be done by drag and drop the column header from one index to another index within the Tree Grid.
                    </p>
                    <p>The location in which the column to be placed, will be indicated by two arrows symbols.</p>
                    <p>In this demo, you can reorder columns by drag and drop.
                    </p>

                    <p>
                        More information on the Reorder can be found in <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/columns/#reorder' >Reorder</a></code> documentation section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Frozen Column",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/frozen-column",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="FrozenData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the frozen columns feature of the Tree Grid. Scroll the movable content horizontally to view the frozen columns with the content.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The freezing feature enables the user to freeze certain columns to scroll remaining movable content. This can be achieved by setting <strong>FrozenColumns</strong> property.
                    </p>
                    <p>
                        In this demo sample, the first column is set to frozen by using the FrozenColumns properties.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-hover",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHover",
                        FileName="RowHover.razor"
                    },
                    new SourceCollection
                    {
                        Id="HoverData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid component with the row hover feature. Move the mouse over the Tree Grid rows
                    to see the hover effect.
                    </p>"
                },
                Description = new string[] {
                    @"<p>Row Hover feature enables us to identify the current row by highlighting them with the mouse hovers. 
                    This can be enabled by setting the <code>EnableHover
                    </code> property as true.
                </p>
                <p>In this demo, by enabling the <code>EnableHover
                </code> property, you can move the mouse over Tree Grid rows to see the hover effect.</p>"
                }
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-height",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowHeightData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the row height feature of the Tree Grid. In this demo, the <b>RowHeight</b> for all the Grid rows can be
                changed as <b>20px</b>, <b>40px</b> and <b>60px</b> on ToolBar button click.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tree Grid has an option to customize the row height by using <code>RowHeight
                    </code> property.
                </p>
                <p>
                    In this sample, we have enabled an option in Toolbar to customize the row height of Tree Grid to 20px, 40px and 60px.
                </p>"
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tree-grid-row-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowTemplate",
                        FileName="TreeGridRowTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowData",
                        FileName="TemplateData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid component with the row template feature. In this sample, we have rendered each Tree Grid
                    row using the template.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid provides a way to use a custom layout for its rows using template feature. The template can be provided with the 
                    <code>RowTemplate</code> sub component.</p>
                    <p>In this demo, we have presented Employee Information with Employee Photo and employee details like Name, Address etc.</p>"
                }
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tree-grid-detail-template",
                FileName = "TreeGridDetailTemplate.razor",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DetailTemplate",
                        FileName="TreeGridDetailTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TemplateData",
                        FileName="TemplateData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid component with the detail template feature.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The detail row template provides an additional information about a data row. The template can be provided with the 
                    <code>DetailTemplate</code> sub component.</p>
                    <p>In this demo, we have presented Employee Information with image in the detail row.</p>"
                }
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/inline-editing",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InlineEditing",
                        FileName="InlineEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates CRUD operations in Tree Grid. You can perform CRUD operations as follows,
                    </p>
                    <ul>
                    <li><code>Add </code> - To add new record, click Add toolbar button.</li>
                    <li><code>Edit</code> - To edit record, double click a row or click toolbar Edit button after selected a row.</li>
                    <li><code>Delete</code> - To delete record, click toolbar Delete button after selected a row.</li>
                    <li><code>Update, Cancel</code> - You can save or discard changes by click toolbar Update and Cancel button respectively.</li>
                </ul>"
                },
                Description = new string[] {
                    @"<p>
                        The Tree Grid supports CRUD operations. This CRUD operations can be configured in Tree Grid using <code>TreeGridEditSettings</code>. Also, it has different modes to manipulate the datasource.
                    </p>
                    <p>
                    The available modes are,
                    </p>
                    <ul>
                    <li><code>EditMode.Row </code></li>
                    <li><code>EditMode.Cell</code></li>
                    <li><code>EditMode.Dialog</code></li>
                    <li><code>EditMode.Batch</code></li>
                    </ul>
                    <p>
                    In this demo, Row mode is enabled for editing by default. You can start editing any row by double clicking on it or clicking on toolbar’s Edit button, then the currently selected row will be changed to edited state. You can change the row values and save edited data to the datasource.
                    </p>
                    <p>
                        More information about Edit Modes can be found in the<code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/edit/?no-cache=1#edit-modes' >Edit modes</a></code> documentation section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/dialog-editing",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DialogEditing",
                        FileName="DialogEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="DialogData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Dialog Editing</p>"
                },
                Description = new string[] {
                    @"<p>
                    The Tree Grid supports CRUD operations. This CRUD operations can be configured in Tree Grid using <code>TreeGridEditSettings</code>. Also, it has different modes to manipulate the datasource.
                </p>
                <p>
                    The available modes are,
                </p>
                <ul>
                    <li><code>EditMode.Row</code></li>
                    <li><code>EditMode.Cell</code></li>
                    <li><code>EditMode.Dialog</code></li>
                    <li><code>EditMode.Batch</code></li>
                </ul>
                <p>
                    In this demo, Dialog mode is enabled for editing by defining <code>Mode</code> as <code>EditMode.Dialog</code>. You can start editing by double clicking a row or clicking on toolbar's Edit button, then the currently selected row will be shown on a dialog and you can change the row values and save edited data to the datasource.</p>"
                }
            },
            new Sample
            {
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/batch-editing",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BatchEditing",
                        FileName="BatchEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="BatchData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Batch Editing</p>"
                },
                Description = new string[] {
                    @"<p>
                    The Tree Grid supports CRUD operations. This CRUD operations can be configured in Tree Grid using <code>TreeGridEditSettings</code>. Also, it has different modes to manipulate the datasource.
                </p>
                <p>
                    The available modes are,
                </p>
                <ul>
                    <li><code>EditMode.Row</code></li>
                    <li><code>EditMode.Cell</code></li>
                    <li><code>EditMode.Dialog</code></li>
                    <li><code>EditMode.Batch</code></li>
                </ul>
                <p>
                    In this demo, Batch mode is enabled for editing by defining <code>Mode</code> as <code>EditMode.Batch</code> with
             <code>NewRowPosition</code> as <code>RowPosition.Below</code>.
            You can start editing by double clicking a cell and can change the cell value. The edited cell will be highlighted while
             navigating to a new cell, so that you know which cells had been edited.
            You can bulk save the edited data to the datasource by click on the toolbar's update button.</p>"
                }
            },
             new Sample
            {
                Name = "Cell Edit Type",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/cell-edit-type",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CellEditType",
                        FileName="CellEditType.razor"
                    },
                    new SourceCollection
                    {
                        Id="CellEditTypeData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the supported cell edit types of Tree Grid columns. The list of cell edit types are as follows,
                    </p>
                    <ul>
                    <li><code>NumericTextBox</code> component for integers, double, and decimal data types.</li>
                    <li><code>DefaultEdit</code> component for string data type.</li>
                    <li><code>DropDownList</code> component for list data type.</li>
                    <li><code>DatePicker</code> component for date data type.</li>
                    <li><code>DateTimePicker</code> component for dateTime data type.</li>
                    <li><code>Checkbox</code> component for boolean data type</li>
                </ul>"
                },
                Description = new string[] {
                    @"<p>
                    In this sample, we show the following editTypes for the Tree Grid columns.
                    </p>
                    <p>
                    The available modes are,
                    </p>
                    <ul>
                        <li><code>NumericTextBox </code></li>
                        <li><code>DropDownList</code></li>
                        <li><code>DatePicker</code></li>
                        <li><code>DefaultEdit</code></li>
                        <li><code>Checkbox</code></li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/command-column",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CommandColumn",
                        FileName="CommandColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommandData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates CRUD operations in Tree Grid using command column. You can perform CRUD operations as follows,
                    </p>
                    <ul>
                        <li><code>Edit</code> - To edit record, double click a row or click Edit button from command column after selected a row.</li>
                        <li><code>Delete</code> - To delete record, click Delete button from command column after selected a row.</li>
                        <li><code>Update, Cancel</code> -You can save or discard changes by click Update and Cancel button from command column respectively.</li>
                    </ul>"
                },
                Description = new string[] {
                    @"<p>
                        The Tree Grid provides an option to render CRUD action buttons in a column by using the CommandColumn feature. The <code>Commands</code> property accepts array of CommandModel object. The predefined command button can be defined by using Type property.
                    </p>
                    <p>
                        The built-in command button are,
                    </p>
                    <ul>
                        <li><code>CommandButtonType.Edit </code></li>
                        <li><code>CommandButtonType.Delete</code></li>
                        <li><code>CommandButtonType.Cancel</code></li>
                        <li><code>CommandButtonType.Save</code></li>
                    </ul>
                    <p>
                    More information on the command column configuration can be found in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/edit/#command-column'>command column</a></code> documentation section.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Edit Template",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/cell-edit-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CellEditTemplate",
                        FileName="CellEditTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditTemplateData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This samples demonstrates the Tree Grid Edit template feature.
                    </p>"
                },
                Description = new string[] {
                    @"<p>In this demo, we have rendered the AutoComplete component for “Task Name” column of Tree Grid using <code>EditTemplate</code> sub component in the column.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/sorting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="SortData",
                        FileName="ShipmentData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid multi sorting feature. To sort two or more columns, hold the CTRL key and click the column header.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Sorting feature enables us to order the data in a particular direction. It can be enabled by setting the <code>AllowSorting</code> as true.
                    </p>
                    <p class='e-grid' style='border:none'>To sort a Tree Grid column by simply click the column header. The icons <span class='e-icons e-icon-ascending'></span>(ascending)
                        and <span class='e-icons e-icon-descending'></span>(descending) specifies the sort direction of a column.</p>
                    <p>By default, multi-sorting is enabled in Tree Grid, to sort multiple column hold <strong>CTRL</strong> key and click the column
                        header. To clear sort for a column, hold <strong>SHIFT</strong> key and click the column header.</p>
                    <p>
                        While using Tree Grid in a touch device, you have an option for multi sorting in single tap on the Tree Grid header. By tapping on the Tree Grid header, it will show the toggle button in small popup with sort icon.
                        Now tap the button to enable the multi-sorting in single tap.
                    </p>
                    <p>In this demo, </p>
                    <ul>
                        <li>Simply click the column header to sort a column.</li>
                    </li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-filtering",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                        FileName="DefaultFiltering.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TreeData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default filterbar in Tree Grid.
                        In this sample, type the value in the filterbar and press enter to filter particular column.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The filtering feature enables the user to view the reduced amount of records based on filter criteria. It can be enabled
                        by setting <code>
                            AllowFiltering
                        </code> property as true. A filter bar row will be rendered next to header which allows the end-users to filter
                        data by entering text within its cells.
                    </p>
                    <p>Filterbar uses two modes which specifies how to start filtering. They are,</p>
                    <ul>
                        <li><code>OnEnter</code> - Enabled by default, filter will be initiated after pressing <code>Enter</code> key.</li>
                        <li>
                            <code>Immediate</code> - Filter will start after user ends typing. This uses a time delay of <i>1500ms</i> to initiate
                            filter after use stops typing. It can be overridden using the <code>
                                TreeGridFilterSettings->ImmediateModeDelay
                            </code> property.
                        </li>
                    </ul>
                    <p>Tree Grid provides support for a set of filtering modes with <code>HierarchyMode</code> property. The below are the type of filter mode available in Tree Grid. </p>
                    <ul>
                        <li>
                            <code>Parent</code> - This is the default filter hierarchy mode in Tree Grid.
                            The filtered records are displayed with its parent records, if the filtered records not have any parent record then the filtered record only displayed.
                        </li>
                        <li><code>Child</code> - The filtered records are displayed with its child record, if the filtered records do not have any child record then only the filtered records are displayed.</li>
                        <li>
                            <code>Both</code> - The filtered records are displayed with its both parent and child record.
                            If the filtered records do not have any parent and child record then only the filtered records are displayed.
                        </li>
                        <li><code>None</code> - Only the filtered records are displayed.</li>
                    </ul>
                    <p>In this demo, <code>Parent</code> hierarchy mode is enabled.</p>"
                }
            },
            new Sample
            {
                Name = "Filterbar Template",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/filter-bar-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                        FileName="FilterBarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterBarTemplateData",
                        FileName="TreeData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the template support of filterbar in Tree Grid.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid provides a way to use custom control for filterbar using filter template feature. 
                        </p>
                        <p>In this demo, using FilterTemplate, we have rendered dropdownlist for Duration Column, from which a value can be selected to filter the column.</p>"
                }
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/menu-filter",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MenuFilter",
                        FileName="MenuFilter.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterData",
                        FileName="TreeData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the way of filtering Tree Grid columns using menu and excel filter UI. In this sample, click the filtering
                    icon from column header to show filter UI for a particular column.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The filtering feature enables the user to view the reduced amount of records based on filter criteria. It can be enabled
                    by setting <code>AllowFiltering
                    </code> property as true.
                    </p>
                    <p>Tree Grid supports the following filter types. They are </p>
                    <ul>
                        <li><code>FilterBar</code></li>
                            <li><code>Menu</code></li>
                            <li><code>Excel</code></li>
                    </ul>
                    you can change the filter type by setting <code>TreeGridFilterSettings->Type</code>.
                    <p>Tree Grid provides support for a set of filtering modes with hierarchyMode property. The below are the type of filter mode available in Tree Grid. </p>
                    <ul>
                    <li><code>Parent</code> - This is the default filter hierarchy mode in Tree Grid. 
                    The filtered records are displayed with its parent records, if the filtered records not have any parent record then the filtered record only displayed.</li>
                    <li><code>Child</code> - The filtered records are displayed with its child record, if the filtered records do not have any child record then only the filtered records are displayed.</li>
                    <li><code>Both</code> - The filtered records are displayed with its both parent and child record.
                    If the filtered records do not have any parent and child record then only the filtered records are displayed.</li>
                    <li><code>None</code> - Only the filtered records are displayed.</li>
                    </ul>

                    <p>In this demo, filter menu enabled by default, you can switch to other hierarchy mode of filtering by using dropdown.</p>"
                }
            },
            new Sample
            {
                Name = "Search",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/search",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Search",
                        FileName="Search.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TreeData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid searching feature. In this sample, use the search box from toolbar to search Tree Grid records.
                    </p>"
                },
                Description = new string[] {
                    @" <p>The Tree Grid has an option to search its content using the search method with search key as the parameter.</p>

                <p>The tree grid supports different types of search mode through the <code>TreeGridSearchSettings.HierarchyMode</code> property.</p>

                <p>The following are the types of search modes available in the tree grid.</p>

                <ul>
                    <li><code>Parent</code> - This is the default search hierarchy mode in the tree grid. It displays a searched record with its parent records. 
                        If the searched records do not have any parent record, it displays only the searched record.</li>

                    <li><code>Child</code> - Displays the searched record with its child record. 
                        If the searched records do not have any child record, it displays only the searched record.</li>

                    <li><code>Both</code> - Displays the searched record with both its parent and child records. 
                        If the searched records do not have any parent and child records, it displays only the searched record.</li>
                        
                    <li><code>None</code> - Displays only the searched record.</li>
                </ul>

                <p>In this demo, The Tree Grid toolbar provides an option to search the Tree Grid's records. The user can type the text box in the toolbar and click search button or press Enter key to perform search operation. 
                    And also we have an option to change the searching hierarchy mode through property panel.</p>

                <p> 
                    For more information check in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/searching/?no-cache=1' >Searching</a></code> documentation section.
                </p>"
                }
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/selection",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Selection",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection feature in Tree Grid, which allows you to select row or cell through simple mouse down or keyboard interaction.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    Selection provides an interactive support to highlight the row or cell that you select. 
                    Selection can be done through a simple
                    Mouse down or Keyboard interaction. To enable selection, set <code>
                    AllowSelection
                    </code> as true.
                </p>
                <p>Tree Grid supports two types of selection which can be set using 
                    <code>
                    TreeGridSelectionSettings->Type
                    </code> property. They are,</p>
                <ul>
                    <li><code>SelectionType.Single</code> - Enabled by default. Allows the user to select single row/cell at a time.</li>
                    <li><code>SelectionType.Multiple</code> - Allows the user to select more than one row/cell at a time.</li>
                </ul>
                <p>To perform the multi-selection, hold <strong>CTRL</strong> key and click the desired rows/cells. 
                To select range of rows/cells, hold <strong>SHIFT</strong> key and click the rows/cells.</p>
                <p>While using the Tree Grid in a touch device environment, there is an option for multi-selection 
                    through single tap on the row and it will show a popup with the multi-selection symbol. 
                    Tap the icon to enable multi-selection in a single tap.
                </p>"
                }
            },
            new Sample
            {
                Name = "Selection API",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/selection-api",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SelectionAPI",
                        FileName="SelectionAPI.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionAPIData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection functionality of the Tree Grid. You can select multiple row by entering start and end index then click the select row button. To clear all selected rows, click clear selection button.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    Selection provides an interactive support to highlight the row or cell that you select. 
                    Selection can be done through a simple Mouse down or Keyboard interaction. 
                    To enable selection, set <code>
                    AllowSelection
                    </code> as true.
                </p>
                <p>Tree Grid supports two types of selection which can be set using 
                    <code>TreeGridSelectionSettings->type
                    </code> property. They are,</p>
                <ul>
                    <li><code>single</code> - Enabled by default. Allows the user to select single row/cell at a time.</li>
                    <li><code>multiple</code> - Allows the user to select more than one row/cell at a time.</li>
                </ul>
                <p>Also, supports three modes of selection which can be set using 
                    <code>TreeGridSelectionSettings->mode
                    </code> property. They are,
                </p>
                <ul>
                    <li><code>Row</code> - Enabled by default. Enables row selection in Tree Grid.</li>
                    <li><code>Cell</code> - Enables cell selection in Tree Grid.</li>
                    <li><code>Both</code> - Enables both row and cell selection in Tree Grid. 
                    Clicking any cell will select both the row and cell simultaneously.
                    </li>
                </ul>
                <p>The Tree Grid supports two types of cell selection mode that can be set by using the  
                        <code>
                        TreeGridSelectionSettings->CellSelectionMode
                        </code> property. They are,</p>
                    <ul>
                        <li><code>Flow</code> - The Flow value is set by default. The range of cells are selected between the start index
                            and end index that includes in between cells of rows.</li>
                        <li><code>Box</code> - Range of cells are selected from the start and 
                            end column indexes that includes in between cells of rows within the range.</li>
                    </ul>
                <p>To perform the multi-selection, hold <strong>CTRL</strong> key and click the desired rows/cells. 
                To select range of rows/cells, hold <strong>SHIFT</strong> key and click the rows/cells.</p>
                <p>While using the Tree Grid in a touch device environment, there is an option for multi-selection 
                    through single tap on the row and it will show a popup with the multi-selection symbol. 
                    Tap the icon to enable multi-selection in a single tap.
                </p>
                <p>In this demo you can select the multiple rows by hold CTRL Key and click the desired rows.
                </p>

                <p>
                    More information on the selection configuration can be found in the <code><a target='_blank' class='code'
                    href='https://blazor.syncfusion.com/documentation/tree-grid/selection/'>
                    documentation
                    </a></code> section.
                </p>"
                }
            },
            new Sample
            {
                Name = "Paging",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/paging",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Paging",
                        FileName="Paging.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Tree Grid paging feature. In this sample, click the numeric items to navigate to another page. You can also change the page size using the dropdown.
                    </p>"
                },
                Description = new string[] {
                    @"Paging allows you to display the contents of the Tree Grid in page segments. By default, paging is disabled. To enable paging,
                    set <code>AllowPaging</code> property to true. <code> TreeGridPageSettings->PageSizes </code> property
                    enables a dropdown in pager which allows you to change the number of records in the Tree Grid dynamically.
                    <p>
                        In this demo, the Tree Grid is rendered with <code>TreeGridPageSettings->PageSizes</code> set to true and 
                        have an option to change the pagesize of Tree Grid dynamically.
                    </p>
                    <p>
                        More information on the paging feature can be found in this  <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/paging/?no-cache=1' >Paging</a></code> documentation section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/checkbox-selection",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CheckBoxSelection",
                        FileName="CheckboxSelection.razor"
                    },
                    new SourceCollection
                    {
                        Id="CheckBoxData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection functionality of the Tree Grid using checkbox selection, To select and unselect all rows use header checkbox. To select/unselect particular row, click the desired row.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Tree Grid mutliple selection can be achieved with help of checkbox in each row. To render checkbox in each Tree Grid row, you need
                        to define column type as <code>Checkbox</code> using <code>TreeGridColumn->Type</code> property.</p>
                    <p>Selection can be persisted on all the operations using
                        <code>TreeGridSelectionSettings-> PersistSelection</code> property. For persisting selection on the Tree Grid, any one of the column should be defined as a
                        primary key using <code> TreeGridColumn->IsPrimaryKey</code> property.</p>
                    <p>
                        In this demo, Tree Grid mutliple selection has been enabled with selection persistance.
                    </p>
                    <p>
                        More information on the checkbox selection configuration can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/tree-grid/selection/#checkbox-selection'>documentation section.
                    </p>"
                }
            },
             //new Sample
             //{
             //    Name = "Checkbox Column",
             //    Category = "Columns",
             //    Directory = "TreeGrid/TreeGrid",
             //    Url = "tree-grid/checkbox-column",
             //    Type = SampleType.None,
             //    TitleTag = "TreeGrid . Checkbox Column . Syncfusion Blazor Components",
             //    MetaDescription = "This demo for Syncfusion Blazor TreeGrid component explains how the hierarchy selection between the records using column checkboxes.",
             //    SourceFiles = new List<SourceCollection>()
             //    {
             //        new SourceCollection
             //        {
             //            Id="Checkbox",
             //            FileName="CheckboxColumn.razor"
             //        },
             //        new SourceCollection
             //        {
             //            Id="CheckboxData",
             //            FileName="SelfData.cs"
             //        }
             //    },
             //    ActionDescription = new string[] {
             //        @"<p>
             //            This sample demonstrates the checkbox column selection functionality of TreeGrid. Click on any parent record checkbox then the child record checkboxes will get selected and parent record checkbox will get selected while checking all of its child items.
             //        </p>"
             //    },
             //    Description = new string[] {
             //        @"<p>
             //            The TreeGrid component can be rendered with checkbox on existing column and also this can be enabled by <code>ShowCheckbox</code> property as true in columns API.
             //        </p>
             //        <p>
             //            For hierarchy selection between the records, we need to enable the <code>AutoCheckHierarchy</code> property.
             //        </p>
             //        <p>
             //            While using TreeGrid in a touch device, you have an option to select the checkboxes by tapping on the checkbox.
             //        </p>
             //        <p>
             //            More information on the Checkbox column can be found in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/columns/?no-cache=1#checkbox-column' >Checkbox</a></code> documentation section.
             //        </p>"
             //    }
             //},
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/exporting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DefaultExporting",
                        FileName="Exporting.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultExportingData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the client-side exporting of the Tree Grid, which allows you to export its data to the Excel, Pdf and CSV formats. Use the toolbar buttons to export Tree Grid data to desired format.</p>"
                },
                Description = new string[] {
                    @"<p>Tree Grid supports client-side exporting which allows you to export its data to the Excel, Pdf and CSV formats.</p>
                <p>In this demo, for the toolbar items of exporting, we have defined actions in <code>OnToolbarClick</code> event to export the Tree Grid data using the <code>ExcelExport</code>, <code>PdfExport</code> and <code>CsvExport</code> methods.</p>
                <p>
                        More information on the exporting can be found in <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/excel-export/' >Excel Export</a></code> and <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/exporting/' >Pdf Export</a></code> documentation section.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/print",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Print",
                        FileName="Print.razor"
                    },
                    new SourceCollection
                    {
                        Id="PrintData",
                        FileName="SelfData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the option to print the Tree Grid. Click the print button from the toolbar item to print Tree Grid.</p>"
                },
                Description = new string[] {
                    @"<p>The Tree Grid can be printed using the <code>Print</code> method. While printing the pager and 
                scrollbar will be removed if they are enabled in Tree Grid.</p>
                <p>By default, all pages will be printed. 
                    We can print current page alone by setting the <code>PrintMode</code>property
                    value as <code>CurrentPage</code>.</p>
                <p>In this demo, click the print icon to print Tree Grid.</p>
                <p>
                    More information on the print feature can be found in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/print/'> documentation</a></code>section.
                </p>"
                }
            },
            new Sample
            {
                Name = "Toolbar Template",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tool-bar-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ToolBartemplate",
                        FileName="ToolBarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ToolBarTemplateData",
                        FileName="TreeData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample explains the way of rendering custom template element Quick Filter in a toolbar and while click on the icon filters the Task Name column in Tree Grid using API.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    Custom toolbar items can be added by defining the toolbar as a collection of ItemModels. Actions for this customized toolbar items are defined in the <code>OnToolbarClick</code> event.
                    </p>
                    <p>In this sample, rendered the custom template element Quick Filter along with predefined toolbar items ExpandAll and CollapseAll. While click on the Quick Filter button then the filtering is applied for Task Name column.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/keyboard-interaction",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="KeyboardInteraction",
                        FileName="KeyboardInteraction.razor"
                    },
                    new SourceCollection
                    {
                        Id="KeyboardInteractionData",
                        FileName="WrapData.cs"
                    }

                },
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the keyboard shortcuts applicable on Tree Grid and also lists out in below description, how those applicable shortcuts interacts with Tree Grid actions.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        All the Tree Grid actions can be controlled via keyboard keys. The applicable key combinations and its relative functionalities are listed below.
                    </p>
                    <p>
                    <table>
                        <tr><td><b>Keys</b></td><td><b>Description</b></td></tr>
                        <tr><td><code>Ctrl + Down Arrow</code></td><td>ExpandAll</td></tr>
                        <tr><td><code>Ctrl + Up Arrow</code></td><td>CollapseAll</td></tr>
                        <tr><td><code>F2</code></td><td>Edit</td></tr>
                        <tr><td><code>ESC</code></td><td>Cancel</td></tr>
                        <tr><td><code>Enter</code></td><td>Save</td></tr>
                        <tr><td><code>Insert</code></td><td>Add</td></tr>
                        <tr><td><code>Delete</code></td><td>Delete</td></tr>
                        <tr><td><code>Ctrl + Home</code></td><td>First row selection</td></tr>
                        <tr><td><code>Ctrl + End</code></td><td>Last row selection</td></tr>
                        <tr><td><code>Home</code></td><td>First cell selection</td></tr>
                        <tr><td><code>End</code></td><td>Last cell selection</td></tr>
                        <tr><td><code>Up Arrow</code></td><td>Move row selection up</td></tr>
                        <tr><td><code>Down Arrow</code></td><td>Move row selection down</td></tr>
                        <tr><td><code>Up Arrow</code></td><td>Move Cell selection up</td></tr>
                        <tr><td><code>Down Arrow</code></td><td>Move Cell selection down</td></tr>
                        <tr><td><code>Right Arrow</code></td><td>Move Cell selection right</td></tr>
                        <tr><td><code>Left Arrow</code></td><td>Move Cell selection left</td></tr>
                        <tr><td><code>Shift + Down/Up</code></td><td>Multiple row Selection</td></tr>
                        <tr><td ><code>Shift + Right/Left/Down/Up</code></td><td>Multiple Cell Selection</td></tr>
                        <tr><td><code>Ctrl + Shift + Up Arrow</code></td><td>Collapse selected parent row</td></tr>
                        <tr><td><code>Ctrl + Shift + Down Arrow</code></td><td>Expand selected parent row</td></tr>
                        <tr><td><code>Ctrl + j</code></td><td>Focus Tree Grid element</td></tr>
                        <tr><td><code>Tab</code></td><td>Go to next cell for editing</td></tr>
                        <tr><td><code>Shift + Tab</code></td><td>Go to previous cell for editing</td></tr>
                        <tr><td><code>PageDown</code></td><td>Go to Next page</td></tr>
                        <tr><td><code>PageUp</code></td><td>Go to Previous page</td></tr>
                        <tr><td><code>Ctrl + Alt + PageUp</code></td><td>Go to First page</td></tr>
                        <tr><td><code>Ctrl + Alt + PageDown</code></td><td>Go to Last page</td></tr>
                        <tr><td><code>Alt + PageUp</code></td><td>Go to Next pager</td></tr>
                        <tr><td><code>Alt + PageDown</code></td><td>Go to last pager</td></tr>
                    </table>
                    </p>

            <p> For more information check in this <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/tree-grid/accessibility/?no-cache=1' >Accessibility</a></code> documentation section.</p>"
                }
             }
        };
    }

}


