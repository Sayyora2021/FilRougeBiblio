import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { IExemplaire } from 'src/Interfaces/IExemplaire';

@Injectable({
  providedIn: 'root'
})
export class ExemplaireService {

  path = 'https://localhost:7120/api/Exemplaires';


  constructor(private http: HttpClient) { 
  }




  create(exemplaire:IExemplaire){
    this.http.post<IExemplaire>(this.path + '/Create',exemplaire).subscribe();
  }




  update(exemplaire:IExemplaire,id:number){
    this.http.put<IExemplaire>(this.path + '/Edit/'+id,exemplaire).subscribe();
  }




  delete(id:number){
    this.http.delete<IExemplaire>(this.path + '/Delete/'+id).subscribe();
  }




  details(id:number) : Observable<IExemplaire>{
    return this.http.get<IExemplaire>(this.path + '/Details/' + id);
  }




  listAll() : Observable<IExemplaire[]>{

    return this.http.get<IExemplaire[]>(this.path).pipe(
    map((data: IExemplaire[]) => {
      return data;
    })
  );

  }

}
