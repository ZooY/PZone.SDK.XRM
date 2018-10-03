using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace PZone.Xrm
{
    /// <summary>
    /// Набор методов для упрощения работы с метаданными.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    // ReSharper disable once InconsistentNaming
    public static class IOrganizationServiceMetadataExtensions
    {
        /// <summary>
        /// Получение метки элемента списка значений.
        /// </summary>
        /// <param name="service">Экземпляр сервиса CRM.</param>
        /// <param name="entityName">Системное имя сущности.</param>
        /// <param name="attributeName">Системное имя атрибута сущности типа "Список значений" (Picklist).</param>
        /// <param name="value">Числовое значение элемента списка.</param>
        /// <returns>
        /// Метод возвращает локальную метку элемента списка значений.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">В метаданных списка нет указанного в <paramref name="value"/> значения.</exception>
        /// <exception cref="InvalidPluginExecutionException">Неизвестная ошибка.</exception>
        public static string RetrievePicklistItemLabel(this IOrganizationService service, string entityName, string attributeName, int value)
        {
            try
            {
                var request = new RetrieveAttributeRequest { EntityLogicalName = entityName, LogicalName = attributeName };
                var response = (RetrieveAttributeResponse)service.Execute(request);
                var picklistMetadata = (PicklistAttributeMetadata)response.AttributeMetadata;
                var option = picklistMetadata.OptionSet.Options.FirstOrDefault(item => item.Value.HasValue && item.Value.Value == value);
                if (option == null)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Getting picklist label error. Unknown value {value}.");
                return option.Label.UserLocalizedLabel.Label;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (InvalidPluginExecutionException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException($"Getting picklist label error. {ex.Message}", ex);
            }
        }
    }
}