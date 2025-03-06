# CuttySpark - WinForms Sparkline Control

A minimal Windows Forms control for displaying sparkline graphs with real-time data updates and configuration options.

## Components

### SparklineGraph
- **Data Handling**  
  - Dynamic data point management (add/remove/clear)  
  - Automatic data truncation via `MaxDataPoints` (10-1000 range)  
  - Float-based values only  

- **Visual Customization**  
  - Configurable line color, width, and smoothing  
  - Optional data point markers  
  - Grid lines with color control  
  - Threshold line with value and color settings  

- **Statistics Overlay**  
  - Toggle visibility of min/max/average/median/range/standard deviation  
  - Position calculation relative to current data window  

### SparklineGraphController
- **Design-Time Integration**  
  - Property grid dropdown for graph selection  
  - Automatic form instance discovery  

- **Configuration Properties**  
  - Direct mapping to SparklineGraph properties  
  - Color pickers for line/grid/threshold elements  
  - Numeric inputs with range validation  

## Requirements
- .NET Framework 4.7.2+ or .NET Core 3.1+
- Visual Studio 2019+ (for designer support)

## Installation

1. **Manual Inclusion**
   - Add `SparklineGraph.cs`, and optionally `SparklineGraphController.cs` and `SparklineGraphEditor.cs` to your project
   - Build solution to enable toolbox items

2. **Package Manager (Recommended)**
   ```powershell
   Install-Package CuttySpark.WinForms
   ```

## Basic Usage 
   ```csharp
// Create and configure graph
var sparkline = new SparklineGraph {
    Dock = DockStyle.Fill,
    LineColor = Color.FromArgb(44, 123, 182),
    MaxDataPoints = 150,
    ShowStatistics = true
};

// Add initial data
sparkline.AddRange(new[] { 18.4f, 22.1f, 19.8f, 25.6f });

// Create controller
var controller = new SparklineGraphController {
    Dock = DockStyle.Right,
    SelectedGraph = sparkline
};

// Add to form
Controls.Add(sparkline);
Controls.Add(controller);
   ```

## Controller Behaviour

- Immediate property synchronization
- Null-safe graph deselection
- Design-time validation of graph references

## Performance Notes

- Uses double-buffering to reduce flicker
- O(n) complexity for data updates
- Statistics calculations cached during render
- Batch updates are best performed with the `BeginUpdate()` and `EndUpdate()` pattern, as shown below

    ```csharp
    // Batch update pattern
    sparkline.BeginUpdate();
    try {
        for (int i = 0; i < 500; i++) {
            sparkline.AddDataPoint(GenerateValue());
        }
    } finally {
        sparkline.EndUpdate();
    }
   ```
