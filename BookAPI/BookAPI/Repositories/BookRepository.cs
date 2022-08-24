using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAPI.Repositories

{
	public class BookRepository : IBookRepository
	{
		private readonly BookContext _Context;

		public BookRepository(BookContext context)
		{
			_Context = context;
		}
		public async Task<Book> Create(Book book)
		{
			_Context.Books.Add(book);
			await _Context.SaveChangesAsync();
			return book;
		}

		public async Task Delete(int id)
		{
			var bookToDelete = await _Context.Books.FindAsync(id);
			_Context.Books.Remove(bookToDelete);	
			await _Context.SaveChangesAsync();

		}

		public async Task<IEnumerable<Book>> Get()
		{
			return await _Context.Books.ToListAsync();

		}

		public async Task<Book> Get(int id)
		{
			return await _Context.Books.FindAsync(id);
		}

		public async Task Update(Book book)
		{
			_Context.Entry(book).State = EntityState.Modified;
			await _Context.SaveChangesAsync();
		}
	}
}
