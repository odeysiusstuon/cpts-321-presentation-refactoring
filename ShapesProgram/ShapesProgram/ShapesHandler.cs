namespace ShapesProgram
{
    using System.Collections.Generic;
    using System.IO;

    internal class ShapesHandler
    {
        List<object> shapes;

        public ShapesHandler()
        {
            this.shapes = new List<object>();
        }

        // Gets the total surface area of a specific type of shape in shapes collection
        public double GetTotalSurfaceArea(string name)
        {
            double sumSurfaceAreas = 0.0d;

            foreach (object shape in shapes)
            {
                if (name == "Cube")
                {
                    if (shape is Cube cube)
                    {
                        sumSurfaceAreas += cube.GetSurfaceArea();
                    }
                }
                else if (name == "Sphere")
                {
                    if (shape is Sphere sphere)
                    {
                        sumSurfaceAreas += sphere.GetSurfaceArea();
                    }
                }
                else if (name == "RectangularPrism")
                {
                    if (shape is RectangularPrism prism)
                    {
                        sumSurfaceAreas += prism.GetSurfaceArea();
                    }
                }
            }

            return sumSurfaceAreas;
        }
        
        // Parse all the shapes in the CSV-formatted text
        public void ParseShapes(TextReader text)
        {
            string textString = text.ReadToEnd();
            string[] shapesDataString = textString.Split('\n');
            
            foreach (string shapeDataString in shapesDataString)
            {
                string[] shapeData = shapeDataString.Split(',');

                if (shapeData.Length > 0)
                {
                    string name = shapeData[0];
                    
                    switch (name)
                    {
                        case "cube":
                            int sideLength;

                            if (int.TryParse(shapeData[1], out sideLength))
                            {
                                Cube cube = new Cube(sideLength);
                                shapes.Add(cube);
                            }

                            break;
                        case "sphere":
                            int radius;

                            if (int.TryParse(shapeData[1], out radius))
                            {
                                Sphere sphere = new Sphere(radius);
                                shapes.Add(sphere);
                            }

                            break;
                        case "rectangular_prism":
                            int length;
                            int width;
                            int height;

                            if (int.TryParse(shapeData[1], out length) && int.TryParse(shapeData[2], out width) && int.TryParse(shapeData[3], out height))
                            {
                                RectangularPrism prism = new RectangularPrism(length, width, height);
                                shapes.Add(prism);
                            }

                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}