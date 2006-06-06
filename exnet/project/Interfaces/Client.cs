using System;
using System.Collections.Generic;
using System.Collections;

namespace Interfaces
{
	/*
	for login and working use
	*/
	
	public enum ErrorStatus
    {
        None=0,
		UserNotExist=1,
        PassWrong=2,
        SessionExpired=4,
        UserNotUnique=8,
        Undefined=16        	
    }
		
	public delegate void ErrorDelegate ();

	public interface IUser
	{		
		string Name { get; set; }
		string Pass { get; set; }		
		string Session { get; set; }
		int ID { get; set; }
		
		ErrorStatus Error { get; set; }		
		
		bool HasError(ErrorStatus error);
		IEnumerable <ErrorStatus> GetErrors();
	
	}	

}

	
