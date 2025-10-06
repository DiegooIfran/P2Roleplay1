namespace Library;
// Representa objetos que proveen defensa

// Creamos esta interfaz para evitar que un ítem ofensivo
// deba implementar métodos de defensa que no usa
// Así seguimos el Principio ISP y mantenemos el diseño claro y flexible
public interface IDefenseItem : IItem
{
    public int Defense { get;}
}