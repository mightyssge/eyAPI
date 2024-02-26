using eyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly ProviderContext _providerContext;

        public ProviderController(ProviderContext providerContext)
        {
            _providerContext = providerContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provider>>> GetProviders()
        {
            if (_providerContext.Providers == null)
            {
                return NotFound();
            }
            return await _providerContext.Providers.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Provider>> GetProvider(int id)
        {
            if (_providerContext.Providers == null)
            {
                return NotFound();
            }

            var provider = await _providerContext.Providers.FindAsync(id);
            if (provider == null)
            {
                return NotFound();
            }

            return provider;
        }

        [HttpPost]
        public async Task<ActionResult<Provider>> PostProvider(Provider provider)
        {
            _providerContext.Providers.Add(provider);
            await _providerContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProvider),new { id = provider.Id }, provider);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutProvider( int id , Provider provider )
        {
            if (id != provider.Id)
            {
                return BadRequest();
            }

            _providerContext.Entry(provider).State = EntityState.Modified;
            try
            {
                await _providerContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProvider( int id)
        {
            if (_providerContext.Providers == null )
            {
                return NotFound();
            }
            var provider = await _providerContext.Providers.FindAsync(id);
            if (provider == null)
            {
                return NotFound();
            }

            _providerContext.Providers.Remove(provider);
            await _providerContext.SaveChangesAsync();

            return Ok();
        }
    }
}
