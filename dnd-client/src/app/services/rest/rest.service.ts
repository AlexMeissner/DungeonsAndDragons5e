import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from 'src/app/dto/user';

//Mock examples
let users: User[] = [
  {
    Username: 'Tim'
  },
  {
    Username: 'Alex'
  }
]
@Injectable({
  providedIn: 'root'
})

export class RestService
{

  private options: object = {
    responseType: "json",
    withCredentials: false
  };

  private baseUrl: string = 'localhost';

  constructor(private http: HttpClient) { }

  login(name: string, pw: string)
  {
    let body = {
      username: name,
      password: pw
    };
    return this.http.post<User>(this.baseUrl + '/login', body, this.options);
  }
}
