namespace Library;
// Separa la lógica de ataque de otros tipos de ítems
//Las clases de armas solo implementan la funcionalidad
// que realmente necesitan (Attack)
public interface IAttackItem : IItem
{
    public int Attack { get; }
}