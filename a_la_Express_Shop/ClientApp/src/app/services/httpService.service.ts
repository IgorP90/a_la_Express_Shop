import {Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class HttpService{
    static http: any;

    constructor(private http:HttpClient){
        this.http = http
    }

    static get(url:string):Observable<any>{
        return this.http.get(url)
    }
}   