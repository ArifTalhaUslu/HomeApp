import { useEffect, useState } from "react";
import Board from "../CommonComponents/Board";

function Home() {
  useEffect(() => {
    getList();
  }, []);

  const [items, setItems] = useState<any>([]);

  const getList = () => {
    //Data fetch

    setItems([
      { id: '1', name: 'arf', age: 41, isBoss: true },
      { id: '2', name: 'qwe', age: 1, isBoss: false },
      { id: '3', name: 'asd', age: 23, isBoss: false },
    ]);
  };

  const handleEdit = (item: any) => {
    console.log("Edit item:", item);
    //kullanım örneği : 
    //service.updateItem(item);
  };

  const handleDelete = (item: any) => {
    console.log("Delete item:", item);
    //kullanım örneği : 
    //service.deleteItem(item.id);
  };

  const isEditable = (item: any) => {//kayıtlarda güncelleme yapılacak ise hangi şartı sağlaması gerektiğinin seçimidir. şart için true dönmek o durumu editable yapar
    //örneğin:
    //if (item.isBoss) return false; //bu durum için açıklama : isBoss özelliği true olan kayıtlar uneditable durumundadır.
    return true;
  };

  const isDeletable = (item: any) => {//kayıtlarda silme yapılacak ise hangi şartı sağlaması gerektiğinin seçimidir. şart için true dönmek o durumu editable yapar
    return true;
  };

  const renderColumn = (column: string, value: any) => {
    //bu ise column customize işlemi için
    if (typeof value === "boolean") {// mesela bool değerler için custom cell body
      return value ? <b>Yes</b> : <b>No</b>;
    }
    if (column == 'age') {//veya tasarımsal customization
      return value && <i><b><u>{value}</u></b></i>
    }
    return value;
  };

  return (
    <div>
      <Board
        items={items}
        onEdit={handleEdit}
        onDelete={handleDelete}
        isEditable={isEditable}
        isDeletable={isDeletable}
        hiddenColumns={["id"]}//görüntülenmesi istenmeyen column'lar için 
        renderColumn={renderColumn}
        hasNewRecordButton={true}
        newRecordButtonOnClick={() => { }}
      />
    </div>
  );
}

export default Home;
