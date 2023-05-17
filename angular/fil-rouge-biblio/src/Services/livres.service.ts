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
    let apiLivre = this.livreToApiLivre(livre);
    console.log("apiLivre"); console.log(apiLivre);
    this.http.post(this.path + '/Create', apiLivre).subscribe(data => { console.log('reponse creation:'); console.log(data) });
  }


  update(livre:ILivre){
    let apiLivre = this.livreToApiLivre(livre);
    console.log("apiLivre"); console.log(apiLivre);
    this.http.put(this.path + '/Edit/'+livre.id, apiLivre).subscribe();
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

  private livreToApiLivre(livre: ILivre) {
    let apiLivre = { titre: livre.titre, isbn: livre.isbn, auteursIds: Array<number>() , themesIds: Array<number>(), tagsIds: Array<number>() }
    
    livre.tags.forEach(tg => apiLivre.tagsIds.push(tg.id));
    livre.themes.forEach(th => apiLivre.themesIds.push(th.id));
    livre.auteurs.forEach(a => apiLivre.auteursIds.push(a.id));

    return apiLivre;
  }

}
