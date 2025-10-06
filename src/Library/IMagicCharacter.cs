namespace Library;
// Creamos esta interfaz separada porque no todos los personajes
// tienen habilidades mágicas
// Además, al separar la magia en una interfaz específica,
// mantenemos el diseño flexible, podemos agregar otros tipos
// de personajes mágicos en el futuro sin modificar nada del resto
public interface IMagicCharacter:ICharacter
{
    void AddMagicItem(IMagicItem magicItem);
    void RemoveMagicItem(IMagicItem magicItem);
}