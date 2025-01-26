using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public BookManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
        {
            var books = await _manager.Book.GetAllBooksAsync(trackChanges);
            return books;
        }

        public async Task<Book?> GetOneBookByIdAsync(int id, bool trackChanges)
        {
            var book = await _manager.Book.GetOneBookByIdAsync(id, trackChanges);

            if (book is null)
            {
                _logger.LogWarning($"{id} numaralı kitap bulunamadı.");
                return null;
            }

            return book;
        }

        public async Task<BookDto> CreateOneBookAsync(BookDtoForInsertion bookDto)
        {
            if (bookDto == null)
            {
                _logger.LogWarning($"Hatalı değer girildi.");
                throw new ArgumentNullException(nameof(bookDto));
            }
             
            var entity = _mapper.Map<Book>(bookDto);

            await _manager.Book.CreateAsync(entity);
            await SaveAsync();

            return _mapper.Map<BookDto>(entity);
        }

        public async Task UpdateOneBookAsync(int id, BookDtoForUpdate bookDto, bool trackChanges)
        {
            if (bookDto == null)
            {
                _logger.LogError($"{id} numaralı kitap bulunamadı.");
                throw new ArgumentNullException(nameof(bookDto));
            }
            var entity = await _manager.Book.GetOneBookByIdAsync(id, trackChanges);

            entity.Title = bookDto.Title;

            await _manager.Book.UpdateAsync(entity);
            await SaveAsync();
        }

        public async Task DeleteOneBookAsync(int id, bool trackChanges)
        {
            var entity = await _manager.Book.GetOneBookByIdAsync(id, trackChanges);

            if (entity == null)
            {
                _logger.LogError($"{id} numaralı kitap bulunamadı.");
                return;
            }


            await _manager.Book.DeleteAsync(entity);
            await SaveAsync();
        }

        public async Task SaveAsync() 
        {
            await _manager.SaveAsync(); 
        }
   
        public async Task SaveChangesForPatchAsync(BookDtoForUpdate bookDtoForUpdate, Book book)
        {
            _mapper.Map(bookDtoForUpdate, book);
            await _manager.SaveAsync();
        }
    }
}
