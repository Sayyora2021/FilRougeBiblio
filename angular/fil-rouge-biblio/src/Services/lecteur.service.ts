import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { Observable, map } from 'rxjs';
import { apiconfig } from 'apiconfig';

@Injectable({
  providedIn: 'root'
})
export class LecteurService {

  path = apiconfig + '/Lecteurs';


  constructor(private http: HttpClient) { 
  }




  create(lecteur:ILecteur){
    this.http.post<ILecteur>(this.path + '/Create',lecteur).subscribe();
  }




  update(lecteur:ILecteur){
    this.http.put<ILecteur>(this.path + '/Edit/'+lecteur.id,lecteur).subscribe();
  }




  delete(id:number){
    this.http.delete<ILecteur>(this.path + '/Delete/'+id).subscribe();
  }




  details(id:number) : Observable<ILecteur>{
    return this.http.get<ILecteur>(this.path + '/Details/' + id);
  }




  listAll() : Observable<ILecteur[]>{

    return this.http.get<ILecteur[]>(this.path).pipe(
    map((data: ILecteur[]) => {
      return data;
    })
  );

  }

}
