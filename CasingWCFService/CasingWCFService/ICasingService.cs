using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CasingWCFService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICasingService
    {

        [OperationContract]
        SimpleFIO GetCase(SimpleFIO nominative, Case @case, Gender? gender = null);

     

        // TODO: Добавьте здесь операции служб
    }
    /// <summary>
    /// Пол 
    /// </summary>
    public enum Gender : byte
    {
        /// <summary>
        /// Мужской
        /// </summary>
        Male = 1,
        /// <summary>
        /// Женский
        /// </summary>
        Female = 2
    }
    /// <summary>
    /// Падеж
    /// </summary>
    public enum Case : byte
    {
        Nominative = 1, Dative = 2, Genitive = 3, Accusative = 4, Instrumental = 5, Prepositional = 6
    }

    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class SimpleFIO
    {


        [DataMember]
        public bool Surname { get; set; }
        [DataMember]
        public bool FirstName { get; set; }
        [DataMember]
        public bool Patronymic { get; set; }


    }
}
