using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;


namespace PZone.Xrm
{
    /// <summary>
    /// Расширение функционала перечисления <see cref="Entity"/>.
    /// </summary>
    // ReSharper disable once CheckNamespace
    public static class EntityExtensions
    {
        /// <summary>
        /// Расширение атрибутного состава сущности из других сущностей.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="otherEntities">Набор других сущностей, атрибуты которых последовательно переносятся в исходную сущность.</param>
        /// <returns>
        /// Метод сливает атрибуты нескольких сущностей в одну.
        /// </returns>
        public static void Extend(this Entity entity, params Entity[] otherEntities)
        {
            foreach (var otherEntity in otherEntities)
            {
                foreach (var attribute in otherEntity.Attributes)
                    entity[attribute.Key] = attribute.Value;
            }
        }



        /// <summary>
        /// Клонирование объекта <see cref="Entity"/>.
        /// </summary>
        /// <param name="entity">Исходная сущность.</param>
        /// <returns>
        /// Метод возвращает новый объект типа <see cref="Entity"/>, полученный путем клонирования исходного объекта.
        /// </returns>
        public static Entity Clone(this Entity entity)
        {
            return ReferenceEquals(entity, null) ? null : JsonConvert.DeserializeObject<Entity>(JsonConvert.SerializeObject(entity));
        }
    }
}