using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace Rowles.WinForms.CuttySpark
{
    /// <summary>
    /// Provides a custom UI editor for selecting a SparklineGraph instance in the designer.
    /// </summary>
    public class SparklineGraphEditor : UITypeEditor
    {
        /// <summary>
        /// Gets the editor style used by the <see cref="EditValue(ITypeDescriptorContext, IServiceProvider, object)"/> method.
        /// </summary>
        /// <param name="context">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <returns>A <see cref="UITypeEditorEditStyle"/> value that indicates the style of editor used by <see cref="EditValue(ITypeDescriptorContext, IServiceProvider, object)"/> method.</returns>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext? context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        /// <summary>
        /// Edits the value of the specified object using the editor style indicated by the <see cref="GetEditStyle(ITypeDescriptorContext)"/> method.
        /// </summary>
        /// <param name="context">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="provider">An <see cref="IServiceProvider"/> that this editor can use to obtain services.</param>
        /// <param name="value">The object to edit the value of.</param>
        /// <returns>The new value of the object. If the value of the object has not changed, this should return the same object it was passed.</returns>
        public override object EditValue(ITypeDescriptorContext context,
                                        IServiceProvider provider,
                                        object? value)
        {
            IWindowsFormsEditorService editorService = null;
            if (provider != null)
            {
                editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            }

            if (editorService != null)
            {
                var controller = context.Instance as SparklineGraphController;
                Form? form = controller.FindForm();

                ListBox lb = new ListBox();
                lb.SelectionMode = SelectionMode.One;
                lb.Click += (s, e) => editorService.CloseDropDown();

                if (form != null)
                {
                    // Exclude the currently selected graph to prevent circular references.
                    var graphs = form.Controls.OfType<SparklineGraph>()
                        .Where(c => !ReferenceEquals(c, controller.SelectedGraph))
                        .ToList();

                    foreach (var graph in graphs)
                    {
                        int index = lb.Items.Add(graph);
                        if (graph == value)
                            lb.SelectedIndex = index;
                    }
                }

                editorService.DropDownControl(lb);
                return lb.SelectedItem ?? value;
            }

            return value;
        }
    }
}