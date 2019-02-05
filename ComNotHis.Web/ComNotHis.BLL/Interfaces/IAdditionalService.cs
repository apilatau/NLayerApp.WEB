using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.BLL.DTO;
using ComNotHis.DAL.Entities;
using ComNotHis.DAL.Interface;

namespace ComNotHis.BLL.Interfaces
{
    public interface IAdditionalService 
    {
        // получает объект для сохранения с уровня представления и создает по нему объект Order и сохраняет его в базу данных.
        void MakeAdditionalServise(AdditionalDTO addDTO);

        //получает все снятия и с помощью автомаппера преобразует их в СнятияDTO и передает на уровень представления
        TakeOffDTO GetTakeoff(int? id);

        //передает отдельное снятие на уровень представления
        IEnumerable<TakeOffDTO> GetCollectionTakeOff();
        
        void Dispose();
    }
}
