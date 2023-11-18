using System.Text.Json;

[Serializable]
public class RectangleDataModel
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public float Scale { get; set; } // Nuevo campo para la escala

    public string DocumentType { get; set; }  // Ejemplo: "Factura", "Producto"
    public string FieldName { get; set; }     // Ejemplo: "Nombre", "Número de Lote"


    // Constructor
    public RectangleDataModel(int x, int y, int width, int height, string docType, string fieldName, float scale)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        DocumentType = docType;
        FieldName = fieldName;
        Scale = scale;
    }



    public RectangleDataModel(Rectangle rectangleData, string doctype, string fieldName, float scale)
    {
        X = rectangleData.X; Y = rectangleData.Y; Width = rectangleData.Width; Height = rectangleData.Height;
        DocumentType = doctype;
        FieldName = fieldName;
        Scale = scale;
    }

    // Constructor sin parámetros
    public RectangleDataModel() { }

    // Método estático para deserializar desde un string JSON
    public static RectangleDataModel FromJson(string jsonString)
    {
        return JsonSerializer.Deserialize<RectangleDataModel>(jsonString);
    }
}
