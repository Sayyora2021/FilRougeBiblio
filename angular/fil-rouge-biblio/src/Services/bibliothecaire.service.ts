import { Injectable } from '@angular/core';
import { IBibliothecaire } from '../Interfaces/IBibliothecaire';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BibliothecaireService {
  path = 'https://localhost:7120/api/Bibliothecaires';


  constructor(private http: HttpClient) { }


   create(bibliothecaire:IBibliothecaire){
    this.http.post<IBibliothecaire>(this.path +'/Create', bibliothecaire).subscribe();
    
 }
 details(id:number) : Observable<IBibliothecaire>{
  return this.http.get<IBibliothecaire>(this.path+ '/Details/' + id);
}

update(bibliothecaire:IBibliothecaire){
  this.http.put<IBibliothecaire>(this.path + '/Edit/'+bibliothecaire.id, bibliothecaire).subscribe();
}


delete(id:number){
  this.http.delete<IBibliothecaire>(this.path +'/Delete/'+id).subscribe();
}
 listAll() : Observable<IBibliothecaire[]>{

  return this.http.get<IBibliothecaire[]>(this.path).pipe(
  map((data: IBibliothecaire[]) => {
    return data;
  })
);


}
}