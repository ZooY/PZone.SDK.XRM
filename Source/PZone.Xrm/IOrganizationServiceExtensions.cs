using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;


namespace PZone.Xrm
{
    /// <summary>
    /// Расширение функционала классов, реализующих интерфейс <see cref="IOrganizationService"/>.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class IOrganizationServiceExtensions
    {
        #region RetrieveMultiple


        /// <summary>
        /// Получение списка записей по запросу FetchXML.
        /// </summary>
        /// <param name="service">Экземпляр сервиса CRM.</param>
        /// <param name="fetchXml">Текст запроса.</param>
        /// <returns>
        /// Метод возвращает список найденных записей.
        /// </returns>
        public static EntityCollection RetrieveMultiple(this IOrganizationService service, string fetchXml)
        {
            return service.RetrieveMultiple(new FetchExpression(fetchXml));
        }


        #endregion


        #region Execute


        /// <summary>
        /// Выполнение запроса и получение ответа указанного типа.
        /// </summary>
        /// <param name="service">Экземпляр сервиса CRM.</param>
        /// <param name="request">Запрос.</param>
        /// <typeparam name="TResponse">Тип ответа запроса.</typeparam>
        /// <returns>
        /// Метод выполняет запрос и возвращает ответ указанного типа.
        /// </returns>
        public static TResponse Execute<TResponse>(this IOrganizationService service, OrganizationRequest request) where TResponse : OrganizationResponse
        {
            return (TResponse)service.Execute(request);
        }


        #endregion
    }
}