import Button from "./Button";

interface TopContentProps {
  hasNewRecordButton?: boolean;
  newRecordButtonOnClick?: () => void;
}

function TopContents(props: TopContentProps) {
  return (
    <>
      {props.hasNewRecordButton && <Button text={'Add New Record'} />}
    </>
  );
}

export default TopContents;
