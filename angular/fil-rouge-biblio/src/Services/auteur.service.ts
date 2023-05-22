import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { apiconfig } from 'apiconfig';

@Injectable({
  providedIn: 'root'
})
export class AuteurService {

  path = apiconfig.adress + '/Auteurs';

  constructor(private http: HttpClient) { 
  }




  create(auteur:IAuteur){
    this.http.post<IAuteur>(this.path + '/Create',auteur).subscribe();
  }




  update(auteur:IAuteur,id:number){
    this.http.put<IAuteur>(this.path + '/Edit/'+id,auteur).subscribe();
  }




  delete(id:number){
    this.http.delete<IAuteur>(this.path + '/Delete/'+id).subscribe();
  }




  details(id:number) : Observable<IAuteur>{
    return this.http.get<IAuteur>(this.path + '/Details/' + id);
  }




  listAll() : Observable<IAuteur[]>{

    return this.http.get<IAuteur[]>(this.path).pipe(
    map((data: IAuteur[]) => {
      return data;
    })
  );

  }

}
