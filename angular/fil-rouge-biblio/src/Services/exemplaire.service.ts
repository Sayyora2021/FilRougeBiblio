import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { apiconfig } from 'apiconfig';
import { Observable, map } from 'rxjs';
import { IExemplaire } from 'src/Interfaces/IExemplaire';

@Injectable({
  providedIn: 'root'
})
export class ExemplaireService {

  path = apiconfig.adress + '/Exemplaires';


  constructor(private http: HttpClient) { 
  }




  create(exemplaire:IExemplaire){
    const body = {
      livreId: exemplaire.livre.id,
      numero: exemplaire.numeroInventaire
    };
    console.log(body);
    this.http.post(this.path + `/Create?numero=${exemplaire.numeroInventaire}&livreId=${exemplaire.livre.id}`,body).subscribe();
  }




  update(exemplaire:IExemplaire){
    const body = {
      id: exemplaire.id,
      livreId: exemplaire.livre.id,
      numero: exemplaire.numeroInventaire
    };
    this.http.put<IExemplaire>(this.path + `/Edit?numero=${exemplaire.numeroInventaire}&livreId=${exemplaire.livre.id}&id=${exemplaire.id}`,body).subscribe();
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
