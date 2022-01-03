using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Constants
{
    public static class Messages
    {
        public static string Success = "İşlem Başarılı";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValıd = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda 23.00 da tekrar deneyiniz";
        public static string ProductListed = "Urunleriniz Listlendi";
        public static string ProductUpdate = "Güncelleme İşleminiz başarili Listlendi";
        public static string ProductDeleted = "Silme işleminiz başarı ile gerçekleşti";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string CheckIfCarPriceControl = "Urun Fiyati 0 dan kucuk olamaz";
        
        
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserGetAll = "Kullanıcılar getirildi";
        public static string UserGet = "Kullanıcı getirildi";


        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerGet = "Müşter getirildii";
        public static string CustomerGetAll = "Müşteriler getirildi";
        public static string CustomerGetByUserId = "Müşteri, Kullanıcıya göre getirildi";
        public static string GetCustomerDetail = "Müşteri detayları getirildi";

        public static string CardAdded = "Card eklendi";
        public static string PaymentAdded = "Ödeme tamamlandı";
        internal static string CardDeleted = "Card Silindi";
        internal static string CardGetAll= "Card Lİstlendi";
        internal static string CardUpdated = "Card Güncellendi";

        public static string CreditCardAdded = "Kredi karti Eklendi";
        public static string CreditCardUpdate = "Kredi karti Güncellendi";
        public static string CreditCardDelete = "Kredi karti Silindi";
        public static string CardAlreadyExist = "Kredi karti Zaten Mevcut";
        public static string CreditCardNotFound = "Kredi karti Bulunmuyor";


        public static string OperationClaimAdded = "Claim Eklendi";
        public static string OperationClaimDeleted = "Claim Silindi";
        public static string OperationClaimUpdate = "Claim Güncellendi";
        public static string OperationClaimListed = "Claim Listelendi";
        public static string OperationClaimGet = "Claim Getirildi";

        public static string UserOperationClaimAdded = "Kullanıcıya rolu eklendi";
        public static string UserOperationClaimUpdated = "Kullanıcının rolu güncellendi";
        public static string UserOperationClaimDeleted = "Kullanıcıya rolu silindi";
        public static string UserOperationClaimListed = "Kullanıcıya rolu listelendi";
        public static string UserOperationClaimGet = "Kullanıcının Rol Bilgileri Listlendi";
    }
}