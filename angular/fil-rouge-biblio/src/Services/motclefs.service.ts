import { Injectable } from '@angular/core';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { HttpClient } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class MotclefsService {

  constructor(private http: HttpClient) { }
 

  create(motclef:IMotClef){
    this.http.post<IMotClef>('https://localhost:7120/api/Lecteurs/Create',motclef).subscribe();
    
  }
}
