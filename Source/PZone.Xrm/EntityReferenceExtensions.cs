using Microsoft.Xrm.Sdk;


namespace PZone.Xrm
{
    /// <summary>
    /// Расширение функциональности класса <see cref="EntityReference"/>.
    /// </summary>
    public static class EntityReferenceExtensions
    {
        /// <summary>
        /// Получение сущности из ссылки.
        /// </summary>
        /// <param name="entityRef">Ссылка на сущность.</param>
        /// <returns>Метод возвращает сущность с именем и идентификатором, соответствующим ссылке.</returns>
        public static Entity ToEntity(this EntityReference entityRef)
        {
            return new Entity(entityRef.LogicalName, entityRef.Id);
        }
    }
}