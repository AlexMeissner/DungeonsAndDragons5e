import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RestService
{

  private defOpt = {
    observe: 'body',
    responseType: 'json',
    withCredentials: false
  };

  constructor() { }
}
