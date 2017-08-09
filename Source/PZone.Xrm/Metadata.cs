namespace PZone.Xrm
{
    /// <summary>
    /// Метаданные стандартных сущностей.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// Веб-ресурс.
        /// </summary>
        public class WebResource
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "webresource";


            /// <summary>
            /// Содержимое ресурса.
            /// </summary>
            public const string Content = "content";


            /// <summary>
            /// Уникальное имя ресурса.
            /// </summary>
            public const string Name = "name";
        }
        

        /// <summary>
        /// E-mail.
        /// </summary>
        public class Email
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "email";
        }


        /// <summary>
        /// Звонок.
        /// </summary>
        public class PhoneCall
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "phonecall";
        }


        /// <summary>
        /// Группа пользователей.
        /// </summary>
        public class Team
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "team";
        }


        /// <summary>
        /// Единица изменения.
        /// </summary>
        public class Unit
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "uom";
        }


        /// <summary>
        /// Продукт предложения.
        /// </summary>
        public class QuoteProduct
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "quotedetail";
        }


        /// <summary>
        /// Предложение.
        /// </summary>
        public class Quote
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "quote";
        }


        /// <summary>
        /// Элемент очереди.
        /// </summary>
        public class QueueItem
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "queueitem";
        }


        /// <summary>
        /// Очередь.
        /// </summary>
        public class Queue
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "queue";
        }


        /// <summary>
        /// Продукт.
        /// </summary>
        public class Product
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "product";
        }


        /// <summary>
        /// Действие Workflow.
        /// </summary>
        public class Workflow
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "workflow";

            /// <summary>
            /// Имя 
            /// </summary>
            public const string Name = "name";

            /// <summary>
            /// Состояние
            /// </summary>
            public const string StateCode = "statecode";
        }


        /// <summary>
        /// Продукт прайс-листа.
        /// </summary>
        public class PriceListProduct
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "productpricelevel";
        }


        /// <summary>
        /// Прайс-лист.
        /// </summary>
        public class PriceList
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "pricelevel";
        }


        /// <summary>
        /// Продукт заказа.
        /// </summary>
        public class OrderProduct
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "salesorderdetail";
        }


        /// <summary>
        /// Заказ.
        /// </summary>
        public class Order
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "salesorder";
        }


        /// <summary>
        /// Продукт возможой сделки.
        /// </summary>
        public class OpportunityProduct
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "opportunityproduct";
        }


        /// <summary>
        /// Возможная сделка.
        /// </summary>
        public class Opportunity
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "opportunity";
        }


        /// <summary>
        /// Маркетинговый список.
        /// </summary>
        public class MarketingList
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "list";
        }


        /// <summary>
        /// Продукт счета.
        /// </summary>
        public class InvoiceProduct
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "invoicedetail";
        }


        /// <summary>
        /// Счет.
        /// </summary>
        public class Invoice
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "invoice";
        }


        /// <summary>
        /// Валюта.
        /// </summary>
        public class Currency
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "transactioncurrency";
        }


        /// <summary>
        /// Подразделение.
        /// </summary>
        public class BusinessUnit
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "businessunit";
        }


        /// <summary>
        /// Пользователь.
        /// </summary>
        public class User
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "systemuser";

            /// <summary>
            /// Основной адрес эл. почты
            /// </summary>
            public const string InternalEmail = "internalemailaddress";

            /// <summary>
            /// Мобильный телефон
            /// </summary>
            public const string Phone = "mobilephone";
        }


        /// <summary>
        /// Организация.
        /// </summary>
        public class Account
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "account";
        }


        /// <summary>
        /// Персона.
        /// </summary>
        public class Contact
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "contact";
        }


        /// <summary>
        /// Интерес.
        /// </summary>
        public class Lead
        {
            /// <summary>
            /// Название сущности в схеме данных.
            /// </summary>
            public const string LogicalName = "lead";
        }


        /// <summary>
        /// Примечание.
        /// </summary>
        public class Annotation
        {
            /// <summary>
            /// Имя сущности
            /// </summary>
            public const string LogicalName = "annotation";

            /// <summary>
            /// Файл в base64
            /// </summary>
            public const string DocumentBody = "documentbody";

            /// <summary>
            /// Имя файла
            /// </summary>
            public const string FileName = "filename";

            /// <summary>
            /// тип файла
            /// </summary>
            public const string MimeType = "mimetype";

            /// <summary>
            /// Id объекта в CRM
            /// </summary>
            public const string ObjectId = "objectid";
        }
    }
}