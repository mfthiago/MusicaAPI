import React from 'react';
import {UserContext} from '../UserContext';
import {Navigate, Link, useParams} from 'react-router-dom';
import AccountNavigation from '../AccountNavigation';
import axios from 'axios';
import {useState,useContext} from 'react';

export default function Agendamento(){
    const{ready,user,setUser} = useContext(UserContext);
    const[redirect, setRedirect] = useState(null);

    let{subpage} = useParams();
    if(subpage === undefined){
        subpage = 'account';
    }

    if(!ready){
        return <div>Loading...</div>
    }

    if(ready && !user){
        return<Navigate to={'/login'} />
    }

    

    

    if(redirect){
        return <Navigate to={redirect} />
    }

    return(
        <div>
            <AccountNavigation />
                <div className="text-center">
                    <Link  className="inline-flex gap-1 bg-primary text-white py-2 px-6 rounded-full" to={'/account/estudios/novo'}>
                        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor" className="size-6">
                            <path strokeLinecap="round" strokeLinejoin="round" d="M12 4.5v15m7.5-7.5h-15" />
                        </svg>
                        Novo Agendamento
                    </Link>
                </div>
        </div>
    )
}