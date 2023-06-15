using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntracityTrans
{
    class Alert
    {
        public static void Message(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        public static void Error(Exception e)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(e.Message, FormAlert.enmType.Error);
        }
        public static void ConSuccess()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Успешное подключение!", FormAlert.enmType.Success);
        }
        public static void DataRefresh()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Данные обновлены!", FormAlert.enmType.Info);
        }
        public static void DelInfo()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Выберите одну строку для удаления", FormAlert.enmType.Warning);
        }
        public static void DelSuccess()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Данные удалены!", FormAlert.enmType.Success);
        }
        public static void EditInfo()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Выберите одну строку для редактирования", FormAlert.enmType.Warning);
        }
        public static void EditSuccess()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Данные изменены!", FormAlert.enmType.Success);
        }
        public static void AddSuccess()
        {
            FormAlert frm = new FormAlert();
            frm.showAlert("Данные добавлены!", FormAlert.enmType.Success);
        }
    }
}
