import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { ILivre } from 'src/Interfaces/ILivre';

@Injectable({
  providedIn: 'root'
})
export class LivresService {

  path = 'https://localhost:7120/api/Livres';


  constructor(private http: HttpClient) { 
  }




  create(livre:ILivre){
    this.http.post<ILivre>(this.path + '/Create',livre).subscribe();
  }




  update(livre:ILivre,id:number){
    this.http.put<ILivre>(this.path + '/Edit/'+id,livre).subscribe();
  }




  delete(id:number){
    this.http.delete<ILivre>(this.path + '/Delete/'+id).subscribe();
  }




  details(id:number) : Observable<ILivre>{
    return this.http.get<ILivre>(this.path + '/Details/' + id);
  }




  listAll() : Observable<ILivre[]>{

    return this.http.get<ILivre[]>(this.path).pipe(
    map((data: ILivre[]) => {
      return data;
    })
  );

  }

}
