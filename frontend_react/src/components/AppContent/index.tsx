import React, { ReactNode } from 'react';

interface Props {
    children: ReactNode
}

const AppContent = (props: Props) => {
    return (
    <div className='col-md-12 px-5'>
        <div className='row gx-5'>
            {props.children}
        </div>
    </div>)
};

export default AppContent;
