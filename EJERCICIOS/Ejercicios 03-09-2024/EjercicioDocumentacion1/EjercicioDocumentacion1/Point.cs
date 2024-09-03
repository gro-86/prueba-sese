namespace EjercicioDocumentacion1
{

    /// <summary>
    /// Clase puntero que contiene dos atributos que equivalen a coordenadas
    /// </summary>
    public class Point
    {
        /// <value>
        /// Coordenadas de ancho (x) y alto (y)
        /// </value>
        public int X;
        public int Y;
        /// <summary>
        /// Método constructor con los parámetros X e Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Unir los parámetros X e Y
        /// </summary>
        /// <returns>Valores X e Y concatenados</returns>
        public string ObtenerCoordinadas()
        {
            return $"({X}, {Y})";
        }
        /// <summary>
        /// Unir los parámetros X e Y
        /// </summary>
        /// <returns>Valores X e Y concatenados</returns>
        public string ObtenerCoordinadasSimples()
        {
            return $"{X}, {Y}";
        }

    }
}
