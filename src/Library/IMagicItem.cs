namespace Library;
// Define el comportamiento esperado de objetos que afectan la magia
// o que permiten lanzar hechizos

// Con esta separación, aplicamos ISP y facilitamos la extensión;
// nuevos ítems mágicos pueden crearse sin modificar el resto del código
public interface IMagicItem 
{
    public string Name { get; set; }
  }