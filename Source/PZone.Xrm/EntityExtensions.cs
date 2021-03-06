﻿using Microsoft.Xrm.Sdk;


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


    /// <summary>
    /// Расширение функциональности класса <see cref="Entity"/>.
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
        /// Копия сущности без значений полей.
        /// </summary>
        /// <param name="entity">Копируемая сущность.</param>
        /// <returns>
        /// Метод возвращет копию сущности, у которой указаны только тип и идентификатор.
        /// </returns>
        public static Entity ToCleanEntity(this Entity entity)
        {
            return new Entity(entity.LogicalName, entity.Id);
        }
    }
}