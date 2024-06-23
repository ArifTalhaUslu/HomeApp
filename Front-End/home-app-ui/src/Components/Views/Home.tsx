import { useEffect, useState } from "react";
import Board from "../CommonComponents/Board";

function Home() {
  useEffect(() => {
    getList();
  }, []);

  const [items, setItems] = useState<any>([]);

  const getList = () => {
    setItems([
      { id: '1', name: 'arf', age: 41, isBoss: true },
      { id: '2', name: 'qwe', age: 1, isBoss: false },
      { id: '3', name: 'asd', age: 23, isBoss: false },
    ]);
  };

  const handleEdit = (item: any) => {
    console.log("Edit item:", item);
    // Düzenleme işlemleri burada yapılacak
  };

  const handleDelete = (item: any) => {
    console.log("Delete item:", item);
    // Silme işlemleri burada yapılacak
  };

  const isEditable = (item: any) => {
    return true;
  };

  const isDeletable = (item: any) => {
    return true;
  };

  const renderColumn = (column: string, value: any) => {
    if (typeof value === "boolean") {
      return value ? <b>Yes</b> : <b>No</b>;
    }
    if (column == 'age') {
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
        hiddenColumns={["id"]}
        renderColumn={renderColumn}
      />
    </div>
  );
}

export default Home;
