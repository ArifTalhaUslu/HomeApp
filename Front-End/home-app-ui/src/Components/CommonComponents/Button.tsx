function Button(props: any) {
    return (
        <>
            <button onClick={props.onClick} className={props.className ? props.className : "btn btn-sm btn-primary px-2 py-0 m-1"}>{props.text && 'Click'}</button>
        </>
    );
}

export default Button;